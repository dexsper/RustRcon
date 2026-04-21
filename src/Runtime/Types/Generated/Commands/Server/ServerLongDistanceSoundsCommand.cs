using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, long-distance ambient sounds (e.g. distant gunfire) are networked to clients; disabling may reduce bandwidth on busy servers</summary>
/// <remarks>Full RCON name: <c>server.long_distance_sounds</c></remarks>
public sealed class ServerLongDistanceSoundsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.long_distance_sounds";

    /// <summary>Reads the current value of <c>server.long_distance_sounds</c>.</summary>
    public static ServerLongDistanceSoundsCommand CreateGet()
    {
        var cmd = CreatePackage<ServerLongDistanceSoundsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.long_distance_sounds</c> to <paramref name="value"/>.</summary>
    public static ServerLongDistanceSoundsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerLongDistanceSoundsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
