using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.projectile_velocitychange</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.projectile_velocitychange</c></remarks>
public sealed class AntihackProjectileVelocitychangeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.projectile_velocitychange";

    /// <summary>Reads the current value of <c>antihack.projectile_velocitychange</c>.</summary>
    public static AntihackProjectileVelocitychangeCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackProjectileVelocitychangeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.projectile_velocitychange</c> to <paramref name="value"/>.</summary>
    public static AntihackProjectileVelocitychangeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackProjectileVelocitychangeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
