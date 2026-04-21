using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.projectile_protection</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.projectile_protection</c></remarks>
public sealed class AntihackProjectileProtectionCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.projectile_protection";

    /// <summary>Reads the current value of <c>antihack.projectile_protection</c>.</summary>
    public static AntihackProjectileProtectionCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackProjectileProtectionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.projectile_protection</c> to <paramref name="value"/>.</summary>
    public static AntihackProjectileProtectionCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AntihackProjectileProtectionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
