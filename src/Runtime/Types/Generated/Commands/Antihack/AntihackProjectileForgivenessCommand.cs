using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.projectile_forgiveness</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.projectile_forgiveness</c></remarks>
public sealed class AntihackProjectileForgivenessCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.projectile_forgiveness";

    /// <summary>Reads the current value of <c>antihack.projectile_forgiveness</c>.</summary>
    public static AntihackProjectileForgivenessCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackProjectileForgivenessCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.projectile_forgiveness</c> to <paramref name="value"/>.</summary>
    public static AntihackProjectileForgivenessCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackProjectileForgivenessCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
