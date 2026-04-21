using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.projectile_trajectory_update</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.projectile_trajectory_update</c></remarks>
public sealed class AntihackProjectileTrajectoryUpdateCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.projectile_trajectory_update";

    /// <summary>Reads the current value of <c>antihack.projectile_trajectory_update</c>.</summary>
    public static AntihackProjectileTrajectoryUpdateCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackProjectileTrajectoryUpdateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.projectile_trajectory_update</c> to <paramref name="value"/>.</summary>
    public static AntihackProjectileTrajectoryUpdateCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackProjectileTrajectoryUpdateCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
