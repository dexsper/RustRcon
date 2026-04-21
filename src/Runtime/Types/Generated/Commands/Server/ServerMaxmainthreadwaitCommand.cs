using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum milliseconds the main game thread will wait for a network operation before timing out; increase to tolerate brief network stalls (clamped 1–1000)</summary>
/// <remarks>Full RCON name: <c>server.maxmainthreadwait</c></remarks>
public sealed class ServerMaxmainthreadwaitCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.maxmainthreadwait";

    /// <summary>Reads the current value of <c>server.maxmainthreadwait</c>.</summary>
    public static ServerMaxmainthreadwaitCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMaxmainthreadwaitCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.maxmainthreadwait</c> to <paramref name="value"/>.</summary>
    public static ServerMaxmainthreadwaitCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerMaxmainthreadwaitCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
