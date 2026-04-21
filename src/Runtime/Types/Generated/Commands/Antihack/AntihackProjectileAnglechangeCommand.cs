using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.projectile_anglechange</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.projectile_anglechange</c></remarks>
public sealed class AntihackProjectileAnglechangeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.projectile_anglechange";

    /// <summary>Reads the current value of <c>antihack.projectile_anglechange</c>.</summary>
    public static AntihackProjectileAnglechangeCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackProjectileAnglechangeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.projectile_anglechange</c> to <paramref name="value"/>.</summary>
    public static AntihackProjectileAnglechangeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackProjectileAnglechangeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
