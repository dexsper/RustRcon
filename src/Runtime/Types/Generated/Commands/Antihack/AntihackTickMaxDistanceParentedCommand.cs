using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.tick_max_distance_parented</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.tick_max_distance_parented</c></remarks>
public sealed class AntihackTickMaxDistanceParentedCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.tick_max_distance_parented";

    /// <summary>Reads the current value of <c>antihack.tick_max_distance_parented</c>.</summary>
    public static AntihackTickMaxDistanceParentedCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackTickMaxDistanceParentedCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.tick_max_distance_parented</c> to <paramref name="value"/>.</summary>
    public static AntihackTickMaxDistanceParentedCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackTickMaxDistanceParentedCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
