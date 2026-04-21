using System.Net.WebSockets;
using System.Text;
using Newtonsoft.Json;
using RustRcon.Types;
using RustRcon.Utility;

namespace RustRcon;

/// <summary>
///     Low-level WebSocket client that handles JSON serialisation / deserialisation,
///     send/receive serialisation, and connection state tracking.
/// </summary>
public class WebSocketClient : IDisposable
{
    // WebSocket requires at most one concurrent SendAsync and one ReceiveAsync at a time.
    // Both semaphores must remain at a limit of 1.
    private readonly SemaphoreSlim _sendSemaphore = new(1, 1);
    private readonly SemaphoreSlim _receiveSemaphore = new(1, 1);

    private readonly Uri _uri;
    private readonly ILogger _logger;
    private readonly ClientWebSocket _webSocket;
    private readonly ReactiveProperty<WebSocketState> _state = new();
    private readonly Encoding _textEncoding = new UTF8Encoding(false);
    private readonly JsonSerializer _jsonSerializer = JsonSerializer.CreateDefault();

    private CancellationTokenSource? _connectionCts;

    /// <summary>
    ///     A <see cref="CancellationToken"/> that is cancelled when the connection is closed.
    ///     Remains valid for the lifetime of a single connection session.
    /// </summary>
    protected CancellationToken ConnectionToken => _connectionCts?.Token ?? CancellationToken.None;

    /// <summary>Observable WebSocket connection state.</summary>
    public ReadOnlyReactiveProperty<WebSocketState> State { get; }

    /// <param name="uri">Full WebSocket URI including password, e.g. <c>ws://host:port/password</c>.</param>
    /// <param name="logger">Optional logger; defaults to console output.</param>
    public WebSocketClient(Uri uri, ILogger? logger = null)
    {
        _uri = uri;
        _logger = logger ?? ConsoleLogger.Instance;
        _webSocket = new ClientWebSocket();
        State = new ReadOnlyReactiveProperty<WebSocketState>(_state);
    }

    /// <summary>Opens the WebSocket connection and starts background state tracking.</summary>
    public virtual async Task ConnectAsync(CancellationToken cancellation = default)
    {
        if (_webSocket.State is WebSocketState.Connecting or WebSocketState.Open)
            throw new InvalidOperationException("Client is already connected.");

        _connectionCts = new CancellationTokenSource();
        _ = TrackStateAsync(_connectionCts.Token);

        await _webSocket.ConnectAsync(_uri, cancellation);
    }

    /// <summary>Sends a close frame and shuts down the connection.</summary>
    public async Task DisconnectAsync(string reason, CancellationToken cancellation = default)
    {
        _connectionCts?.Cancel();
        _state.Value = WebSocketState.Closed;

        if (!CanSend())
            return;

        await _webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, reason, cancellation);
    }

    /// <summary>Serialises <paramref name="value"/> as JSON and sends it over the socket.</summary>
    protected async Task SendAsync<T>(T value, CancellationToken cancellation)
    {
        if (_webSocket.State != WebSocketState.Open)
            throw new InvalidOperationException("Client is not connected.");

        await _sendSemaphore.WaitAsync(cancellation);

        using var linkedCts = CancellationTokenSource.CreateLinkedTokenSource(
            _connectionCts!.Token, cancellation);

        try
        {
            await using var stream = new MemoryStream();
            await using (var writer = new StreamWriter(stream, _textEncoding, 1024, leaveOpen: true))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                _jsonSerializer.Serialize(jsonWriter, value);
                await jsonWriter.FlushAsync(linkedCts.Token);
            }

            var buffer = new ArraySegment<byte>(stream.GetBuffer(), 0, (int)stream.Length);
            await _webSocket.SendAsync(buffer, WebSocketMessageType.Text, true, linkedCts.Token);
        }
        catch (WebSocketException ex) when (ex.WebSocketErrorCode == WebSocketError.ConnectionClosedPrematurely)
        {
            await DisconnectAsync(ex.ErrorCode.ToString(), CancellationToken.None);
            Log($"WebSocket closed prematurely during send: {ex.Message}");
        }
        finally
        {
            _sendSemaphore.Release();
        }
    }

    /// <summary>Reads the next JSON message from the socket and deserialises it as <typeparamref name="T"/>.</summary>
    protected async Task<T?> ReadAsync<T>(CancellationToken cancellation = default) where T : class
    {
        await _receiveSemaphore.WaitAsync(cancellation);

        using var linkedCts = CancellationTokenSource.CreateLinkedTokenSource(
            _connectionCts!.Token, cancellation);

        try
        {
            if (!CanSend())
                return null;

            await using var stream = new MemoryStream();
            var receiveBuffer = new byte[4096];
            var buffer = new ArraySegment<byte>(receiveBuffer);

            WebSocketReceiveResult result;
            do
            {
                linkedCts.Token.ThrowIfCancellationRequested();
                result = await _webSocket.ReceiveAsync(buffer, linkedCts.Token);

                switch (result.MessageType)
                {
                    case WebSocketMessageType.Close:
                        Log($"Server closed connection: {result.CloseStatusDescription}");
                        await DisconnectAsync(result.CloseStatusDescription ?? string.Empty, CancellationToken.None);
                        return null;

                    case WebSocketMessageType.Text:
                        await stream.WriteAsync(receiveBuffer.AsMemory(0, result.Count), linkedCts.Token);
                        break;
                }
            } while (!result.EndOfMessage);

            stream.Seek(0, SeekOrigin.Begin);

            using var reader = new StreamReader(stream);
            using var jsonReader = new JsonTextReader(reader);
            return _jsonSerializer.Deserialize<T>(jsonReader);
        }
        catch (WebSocketException ex) when (ex.WebSocketErrorCode == WebSocketError.ConnectionClosedPrematurely)
        {
            await DisconnectAsync(ex.ErrorCode.ToString(), CancellationToken.None);
            Log($"WebSocket closed prematurely during read: {ex.Message}");
            return null;
        }
        finally
        {
            _receiveSemaphore.Release();
        }
    }

    /// <summary>Writes a diagnostic message via the configured logger.</summary>
    protected void Log(string message) => _logger.Log(message);

    /// <inheritdoc/>
    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    /// <summary>Releases managed resources. Override to add teardown logic in subclasses.</summary>
    protected virtual void Dispose(bool disposing)
    {
        if (!disposing) return;

        _connectionCts?.Cancel();
        _connectionCts?.Dispose();
        _connectionCts = null;

        _webSocket.Dispose();
        _sendSemaphore.Dispose();
        _receiveSemaphore.Dispose();
    }

    private async Task TrackStateAsync(CancellationToken cancellation)
    {
        while (!cancellation.IsCancellationRequested)
        {
            var current = _webSocket.State;
            if (current != _state.Value)
            {
                _state.Value = current;
                Log($"Connection state changed: {current}");
            }

            try
            {
                await Task.Delay(500, cancellation);
            }
            catch (OperationCanceledException)
            {
                break;
            }
        }
    }

    private bool CanSend()
    {
        return _webSocket.State is not WebSocketState.Aborted
            and not WebSocketState.Closed
            and not WebSocketState.CloseSent;
    }

    private sealed class ConsoleLogger : ILogger
    {
        public static readonly ConsoleLogger Instance = new();
        public void Log(string message) => Console.WriteLine($"[RustRcon] {message}");
    }
}