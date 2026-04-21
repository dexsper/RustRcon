using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.projectile_losforgiveness</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.projectile_losforgiveness</c></remarks>
public sealed class AntihackProjectileLosforgivenessCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.projectile_losforgiveness";

    /// <summary>Reads the current value of <c>antihack.projectile_losforgiveness</c>.</summary>
    public static AntihackProjectileLosforgivenessCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackProjectileLosforgivenessCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.projectile_losforgiveness</c> to <paramref name="value"/>.</summary>
    public static AntihackProjectileLosforgivenessCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackProjectileLosforgivenessCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
