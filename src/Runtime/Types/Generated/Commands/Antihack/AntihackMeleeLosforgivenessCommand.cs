using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.melee_losforgiveness</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.melee_losforgiveness</c></remarks>
public sealed class AntihackMeleeLosforgivenessCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.melee_losforgiveness";

    /// <summary>Reads the current value of <c>antihack.melee_losforgiveness</c>.</summary>
    public static AntihackMeleeLosforgivenessCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackMeleeLosforgivenessCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.melee_losforgiveness</c> to <paramref name="value"/>.</summary>
    public static AntihackMeleeLosforgivenessCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackMeleeLosforgivenessCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
