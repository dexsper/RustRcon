using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.projectile_trajectory</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.projectile_trajectory</c></remarks>
public sealed class AntihackProjectileTrajectoryCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.projectile_trajectory";

    /// <summary>Reads the current value of <c>antihack.projectile_trajectory</c>.</summary>
    public static AntihackProjectileTrajectoryCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackProjectileTrajectoryCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.projectile_trajectory</c> to <paramref name="value"/>.</summary>
    public static AntihackProjectileTrajectoryCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackProjectileTrajectoryCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
