using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How much area around the player is revealed when using fog of war. Must be a multiple of 32</summary>
/// <remarks>Full RCON name: <c>server.fogofwarrevealsize</c></remarks>
public sealed class ServerFogofwarrevealsizeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.fogofwarrevealsize";

    /// <summary>Reads the current value of <c>server.fogofwarrevealsize</c>.</summary>
    public static ServerFogofwarrevealsizeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerFogofwarrevealsizeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.fogofwarrevealsize</c> to <paramref name="value"/>.</summary>
    public static ServerFogofwarrevealsizeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerFogofwarrevealsizeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
