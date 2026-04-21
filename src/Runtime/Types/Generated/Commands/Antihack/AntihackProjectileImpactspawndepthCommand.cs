using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.projectile_impactspawndepth</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.projectile_impactspawndepth</c></remarks>
public sealed class AntihackProjectileImpactspawndepthCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.projectile_impactspawndepth";

    /// <summary>Reads the current value of <c>antihack.projectile_impactspawndepth</c>.</summary>
    public static AntihackProjectileImpactspawndepthCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackProjectileImpactspawndepthCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.projectile_impactspawndepth</c> to <paramref name="value"/>.</summary>
    public static AntihackProjectileImpactspawndepthCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AntihackProjectileImpactspawndepthCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
