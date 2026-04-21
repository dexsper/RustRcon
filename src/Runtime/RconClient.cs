using System.Collections.Concurrent;
using Newtonsoft.Json;
using RustRcon.Pooling;
using RustRcon.Types;
using RustRcon.Types.Commands.Base;
using RustRcon.Types.Response.Server;
using RustRcon.Types.Server.Messages;

namespace RustRcon;

/// <summary>
///     High-level RCON client for a Rust game server.
///     Handles command correlation, chat messages, and console output streaming.
/// </summary>
public sealed class RconClient : WebSocketClient
{
    private readonly ConcurrentDictionary<int, TaskCompletionSource<ServerResponse>> _pending = new();

    private Task? _readLoopTask;

    /// <summary>
    ///     Raised when the server emits an unsolicited console message.
    ///     <para>
    ///         The <see cref="ConsoleMsg"/> is owned by the pool.  Subscribers must not hold
    ///         a reference after the event handler returns — clone the data if needed.
    ///     </para>
    /// </summary>
    public event Action<ConsoleMsg>? OnConsoleMessage;

    /// <summary>
    ///     Raised when the server broadcasts a chat message.
    ///     <para>
    ///         The <see cref="ChatMsg"/> is owned by the pool.  Subscribers must not hold
    ///         a reference after the event handler returns — clone the data if needed.
    ///     </para>
    /// </summary>
    public event Action<ChatMsg>? OnChatMessage;

    /// <summary>
    ///     Initialises a new RCON connection.
    /// </summary>
    /// <param name="host">Server hostname or IP address.</param>
    /// <param name="port">WebSocket RCON port (typically game port + 1).</param>
    /// <param name="password">RCON password.</param>
    /// <param name="logger">Optional logger; defaults to console output.</param>
    public RconClient(string host, int port, string password, ILogger? logger = null)
        : base(new Uri($"ws://{host}:{port}/{password}"), logger)
    {
    }

    /// <inheritdoc/>
    public override async Task ConnectAsync(CancellationToken cancellation = default)
    {
        await base.ConnectAsync(cancellation);
        _readLoopTask = ReadLoopAsync(ConnectionToken).ContinueWith(
            t => Log($"Read loop faulted: {t.Exception!.GetBaseException().Message}"),
            TaskContinuationOptions.OnlyOnFaulted
        );
    }

    /// <summary>
    ///     Sends <paramref name="command"/> and waits for the server's correlated response.
    ///     The <see cref="BaseCommand.Complete"/> method is called with the response before
    ///     this task completes.
    /// </summary>
    public async Task SendCommandAsync(BaseCommand command, CancellationToken cancellationToken = default)
    {
        if (command is null) throw new ArgumentNullException(nameof(command));

        var tcs = new TaskCompletionSource<ServerResponse>(
            TaskCreationOptions.RunContinuationsAsynchronously);

        _pending[command.Id] = tcs;

        await using var reg = cancellationToken.Register(() =>
        {
            if (_pending.TryRemove(command.Id, out _))
                tcs.TrySetCanceled(cancellationToken);
        });

        try
        {
            await SendAsync(command, cancellationToken);
        }
        catch
        {
            _pending.TryRemove(command.Id, out _);
            throw;
        }

        var response = await tcs.Task;
        command.Complete(response);
    }

    private async Task ReadLoopAsync(CancellationToken cancellation)
    {
        while (!cancellation.IsCancellationRequested)
        {
            ServerResponse? response;

            try
            {
                response = await ReadAsync<ServerResponse>(cancellation);
            }
            catch (OperationCanceledException)
            {
                break;
            }

            if (response is null)
                continue;

            if (!_pending.TryRemove(response.Id, out var tcs))
            {
                HandleUnsolicited(response);
                continue;
            }

            tcs.TrySetResult(response);
        }

        foreach (var tcs in _pending.Values)
            tcs.TrySetCanceled();

        _pending.Clear();
    }

    private void HandleUnsolicited(ServerResponse response)
    {
        if (response.Content.StartsWith("[rcon]", StringComparison.Ordinal))
            return;

        ConsoleMsg? consoleMsg = null;
        ChatMsg? chatMsg = null;

        try
        {
            if (response.Id == 0)
            {
                consoleMsg = RustRconPool.Get<ConsoleMsg>();
                consoleMsg.Message = response.Content;
                consoleMsg.Type = Enum.TryParse<ConsoleMsg.MessageType>(response.Type, ignoreCase: true, out var t)
                    ? t
                    : ConsoleMsg.MessageType.Generic;

                OnConsoleMessage?.Invoke(consoleMsg);
                return;
            }

            if (response.Type != "Chat")
                return;

            chatMsg = RustRconPool.Get<ChatMsg>();
            JsonConvert.PopulateObject(response.Content, chatMsg);
            OnChatMessage?.Invoke(chatMsg);
        }
        catch (Exception ex)
        {
            Log($"Error handling unsolicited message: {ex.Message}");
        }
        finally
        {
            consoleMsg?.Dispose();
            chatMsg?.Dispose();
        }
    }
    
    /// <inheritdoc/>
    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);
        if (disposing)
            _readLoopTask = null;
    }
}