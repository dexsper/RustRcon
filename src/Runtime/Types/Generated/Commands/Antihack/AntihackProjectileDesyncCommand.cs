using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.projectile_desync</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.projectile_desync</c></remarks>
public sealed class AntihackProjectileDesyncCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.projectile_desync";

    /// <summary>Reads the current value of <c>antihack.projectile_desync</c>.</summary>
    public static AntihackProjectileDesyncCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackProjectileDesyncCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.projectile_desync</c> to <paramref name="value"/>.</summary>
    public static AntihackProjectileDesyncCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackProjectileDesyncCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
