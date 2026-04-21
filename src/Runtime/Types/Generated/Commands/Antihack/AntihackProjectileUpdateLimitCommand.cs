using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.projectile_update_limit</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.projectile_update_limit</c></remarks>
public sealed class AntihackProjectileUpdateLimitCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.projectile_update_limit";

    /// <summary>Reads the current value of <c>antihack.projectile_update_limit</c>.</summary>
    public static AntihackProjectileUpdateLimitCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackProjectileUpdateLimitCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.projectile_update_limit</c> to <paramref name="value"/>.</summary>
    public static AntihackProjectileUpdateLimitCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AntihackProjectileUpdateLimitCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
