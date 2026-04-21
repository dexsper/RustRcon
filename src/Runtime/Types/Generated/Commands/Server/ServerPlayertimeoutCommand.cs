using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Seconds of network inactivity before a connected player is timed out and disconnected</summary>
/// <remarks>Full RCON name: <c>server.playertimeout</c></remarks>
public sealed class ServerPlayertimeoutCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.playertimeout";

    /// <summary>Reads the current value of <c>server.playertimeout</c>.</summary>
    public static ServerPlayertimeoutCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPlayertimeoutCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.playertimeout</c> to <paramref name="value"/>.</summary>
    public static ServerPlayertimeoutCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerPlayertimeoutCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
