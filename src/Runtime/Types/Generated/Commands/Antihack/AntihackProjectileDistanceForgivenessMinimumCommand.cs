using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.projectile_distance_forgiveness_minimum</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.projectile_distance_forgiveness_minimum</c></remarks>
public sealed class AntihackProjectileDistanceForgivenessMinimumCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.projectile_distance_forgiveness_minimum";

    /// <summary>Reads the current value of <c>antihack.projectile_distance_forgiveness_minimum</c>.</summary>
    public static AntihackProjectileDistanceForgivenessMinimumCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackProjectileDistanceForgivenessMinimumCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.projectile_distance_forgiveness_minimum</c> to <paramref name="value"/>.</summary>
    public static AntihackProjectileDistanceForgivenessMinimumCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackProjectileDistanceForgivenessMinimumCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
