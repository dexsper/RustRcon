using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.projectile_clientframes</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.projectile_clientframes</c></remarks>
public sealed class AntihackProjectileClientframesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.projectile_clientframes";

    /// <summary>Reads the current value of <c>antihack.projectile_clientframes</c>.</summary>
    public static AntihackProjectileClientframesCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackProjectileClientframesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.projectile_clientframes</c> to <paramref name="value"/>.</summary>
    public static AntihackProjectileClientframesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackProjectileClientframesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
