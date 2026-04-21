using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, missions are available and can be assigned to players; disable to globally suppress mission generation and assignment on the server</summary>
/// <remarks>Full RCON name: <c>basemission.missionsenabled</c></remarks>
public sealed class BasemissionMissionsenabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "basemission.missionsenabled";

    /// <summary>Reads the current value of <c>basemission.missionsenabled</c>.</summary>
    public static BasemissionMissionsenabledCommand CreateGet()
    {
        var cmd = CreatePackage<BasemissionMissionsenabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>basemission.missionsenabled</c> to <paramref name="value"/>.</summary>
    public static BasemissionMissionsenabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<BasemissionMissionsenabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
