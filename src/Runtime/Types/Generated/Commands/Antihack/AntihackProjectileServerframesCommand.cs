using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.projectile_serverframes</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.projectile_serverframes</c></remarks>
public sealed class AntihackProjectileServerframesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.projectile_serverframes";

    /// <summary>Reads the current value of <c>antihack.projectile_serverframes</c>.</summary>
    public static AntihackProjectileServerframesCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackProjectileServerframesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.projectile_serverframes</c> to <paramref name="value"/>.</summary>
    public static AntihackProjectileServerframesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackProjectileServerframesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
