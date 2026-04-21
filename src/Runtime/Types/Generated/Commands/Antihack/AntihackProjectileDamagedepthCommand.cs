using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.projectile_damagedepth</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.projectile_damagedepth</c></remarks>
public sealed class AntihackProjectileDamagedepthCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.projectile_damagedepth";

    /// <summary>Reads the current value of <c>antihack.projectile_damagedepth</c>.</summary>
    public static AntihackProjectileDamagedepthCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackProjectileDamagedepthCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.projectile_damagedepth</c> to <paramref name="value"/>.</summary>
    public static AntihackProjectileDamagedepthCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AntihackProjectileDamagedepthCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
