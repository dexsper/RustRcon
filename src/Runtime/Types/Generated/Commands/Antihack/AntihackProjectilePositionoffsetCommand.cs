using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.projectile_positionoffset</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.projectile_positionoffset</c></remarks>
public sealed class AntihackProjectilePositionoffsetCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.projectile_positionoffset";

    /// <summary>Reads the current value of <c>antihack.projectile_positionoffset</c>.</summary>
    public static AntihackProjectilePositionoffsetCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackProjectilePositionoffsetCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.projectile_positionoffset</c> to <paramref name="value"/>.</summary>
    public static AntihackProjectilePositionoffsetCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackProjectilePositionoffsetCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
