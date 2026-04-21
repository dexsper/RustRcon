using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Opens a loot panel when interacting with a workbench instead of going straight into the tech tree. Designed for backwards compatibility with mods.</summary>
/// <remarks>Full RCON name: <c>server.uselegacyworkbenchinteraction</c></remarks>
public sealed class ServerUselegacyworkbenchinteractionCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.uselegacyworkbenchinteraction";

    /// <summary>Reads the current value of <c>server.uselegacyworkbenchinteraction</c>.</summary>
    public static ServerUselegacyworkbenchinteractionCommand CreateGet()
    {
        var cmd = CreatePackage<ServerUselegacyworkbenchinteractionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.uselegacyworkbenchinteraction</c> to <paramref name="value"/>.</summary>
    public static ServerUselegacyworkbenchinteractionCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerUselegacyworkbenchinteractionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
