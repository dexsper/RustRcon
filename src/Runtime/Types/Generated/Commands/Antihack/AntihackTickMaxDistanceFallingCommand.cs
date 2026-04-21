using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.tick_max_distance_falling</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.tick_max_distance_falling</c></remarks>
public sealed class AntihackTickMaxDistanceFallingCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.tick_max_distance_falling";

    /// <summary>Reads the current value of <c>antihack.tick_max_distance_falling</c>.</summary>
    public static AntihackTickMaxDistanceFallingCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackTickMaxDistanceFallingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.tick_max_distance_falling</c> to <paramref name="value"/>.</summary>
    public static AntihackTickMaxDistanceFallingCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackTickMaxDistanceFallingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
