using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.tick_distance_forgiveness</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.tick_distance_forgiveness</c></remarks>
public sealed class AntihackTickDistanceForgivenessCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.tick_distance_forgiveness";

    /// <summary>Reads the current value of <c>antihack.tick_distance_forgiveness</c>.</summary>
    public static AntihackTickDistanceForgivenessCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackTickDistanceForgivenessCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.tick_distance_forgiveness</c> to <paramref name="value"/>.</summary>
    public static AntihackTickDistanceForgivenessCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackTickDistanceForgivenessCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
