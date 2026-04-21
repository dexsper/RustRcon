using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The range at which the tiger will charge instead of fleeing if aimed at</summary>
/// <remarks>Full RCON name: <c>tigerfsm.chargerange</c></remarks>
public sealed class TigerfsmChargerangeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "tigerfsm.chargerange";

    /// <summary>Reads the current value of <c>tigerfsm.chargerange</c>.</summary>
    public static TigerfsmChargerangeCommand CreateGet()
    {
        var cmd = CreatePackage<TigerfsmChargerangeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>tigerfsm.chargerange</c> to <paramref name="value"/>.</summary>
    public static TigerfsmChargerangeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<TigerfsmChargerangeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
