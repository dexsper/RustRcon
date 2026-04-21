using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints the current server decryption queue depth</summary>
/// <remarks>Full RCON name: <c>server.rust_relay_send_queue</c></remarks>
public sealed class ServerRustRelaySendQueueCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.rust_relay_send_queue";

    /// <summary>Reads the current value of <c>server.rust_relay_send_queue</c>.</summary>
    public static ServerRustRelaySendQueueCommand CreateGet()
    {
        var cmd = CreatePackage<ServerRustRelaySendQueueCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.rust_relay_send_queue</c> to <paramref name="value"/>.</summary>
    public static ServerRustRelaySendQueueCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerRustRelaySendQueueCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
