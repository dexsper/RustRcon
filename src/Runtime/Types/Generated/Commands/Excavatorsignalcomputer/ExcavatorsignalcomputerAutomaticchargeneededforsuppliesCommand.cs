using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Amount of charge required for the excavator to automatically trigger supply drop delivery without player activation</summary>
/// <remarks>Full RCON name: <c>excavatorsignalcomputer.automaticchargeneededforsupplies</c></remarks>
public sealed class ExcavatorsignalcomputerAutomaticchargeneededforsuppliesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "excavatorsignalcomputer.automaticchargeneededforsupplies";

    /// <summary>Reads the current value of <c>excavatorsignalcomputer.automaticchargeneededforsupplies</c>.</summary>
    public static ExcavatorsignalcomputerAutomaticchargeneededforsuppliesCommand CreateGet()
    {
        var cmd = CreatePackage<ExcavatorsignalcomputerAutomaticchargeneededforsuppliesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>excavatorsignalcomputer.automaticchargeneededforsupplies</c> to <paramref name="value"/>.</summary>
    public static ExcavatorsignalcomputerAutomaticchargeneededforsuppliesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ExcavatorsignalcomputerAutomaticchargeneededforsuppliesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
