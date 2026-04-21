using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.melee_forgiveness</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.melee_forgiveness</c></remarks>
public sealed class AntihackMeleeForgivenessCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.melee_forgiveness";

    /// <summary>Reads the current value of <c>antihack.melee_forgiveness</c>.</summary>
    public static AntihackMeleeForgivenessCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackMeleeForgivenessCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.melee_forgiveness</c> to <paramref name="value"/>.</summary>
    public static AntihackMeleeForgivenessCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackMeleeForgivenessCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
