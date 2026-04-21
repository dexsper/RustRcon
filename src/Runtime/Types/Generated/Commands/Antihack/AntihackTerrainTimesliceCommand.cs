using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.terrain_timeslice</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.terrain_timeslice</c></remarks>
public sealed class AntihackTerrainTimesliceCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.terrain_timeslice";

    /// <summary>Reads the current value of <c>antihack.terrain_timeslice</c>.</summary>
    public static AntihackTerrainTimesliceCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackTerrainTimesliceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.terrain_timeslice</c> to <paramref name="value"/>.</summary>
    public static AntihackTerrainTimesliceCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AntihackTerrainTimesliceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
