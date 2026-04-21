using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.impact_effect_distance_forgiveness</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.impact_effect_distance_forgiveness</c></remarks>
public sealed class AntihackImpactEffectDistanceForgivenessCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.impact_effect_distance_forgiveness";

    /// <summary>Reads the current value of <c>antihack.impact_effect_distance_forgiveness</c>.</summary>
    public static AntihackImpactEffectDistanceForgivenessCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackImpactEffectDistanceForgivenessCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.impact_effect_distance_forgiveness</c> to <paramref name="value"/>.</summary>
    public static AntihackImpactEffectDistanceForgivenessCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackImpactEffectDistanceForgivenessCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
