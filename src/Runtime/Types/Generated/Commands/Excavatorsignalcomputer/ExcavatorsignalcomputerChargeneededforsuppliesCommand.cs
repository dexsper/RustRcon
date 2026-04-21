using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Amount of charge (in seconds of operation) the excavator signal computer requires before it can manually call a supply drop</summary>
/// <remarks>Full RCON name: <c>excavatorsignalcomputer.chargeneededforsupplies</c></remarks>
public sealed class ExcavatorsignalcomputerChargeneededforsuppliesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "excavatorsignalcomputer.chargeneededforsupplies";

    /// <summary>Reads the current value of <c>excavatorsignalcomputer.chargeneededforsupplies</c>.</summary>
    public static ExcavatorsignalcomputerChargeneededforsuppliesCommand CreateGet()
    {
        var cmd = CreatePackage<ExcavatorsignalcomputerChargeneededforsuppliesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>excavatorsignalcomputer.chargeneededforsupplies</c> to <paramref name="value"/>.</summary>
    public static ExcavatorsignalcomputerChargeneededforsuppliesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ExcavatorsignalcomputerChargeneededforsuppliesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
