using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Enables automatic server-side game events such as helicopter patrols, airdrops and cargo ship visits</summary>
/// <remarks>Full RCON name: <c>server.events</c></remarks>
public sealed class ServerEventsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.events";

    /// <summary>Reads the current value of <c>server.events</c>.</summary>
    public static ServerEventsCommand CreateGet()
    {
        var cmd = CreatePackage<ServerEventsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.events</c> to <paramref name="value"/>.</summary>
    public static ServerEventsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerEventsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
