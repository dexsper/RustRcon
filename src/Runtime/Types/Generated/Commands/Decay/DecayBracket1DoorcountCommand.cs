using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Number of doors in the 2nd upkeep bracket</summary>
/// <remarks>Full RCON name: <c>decay.bracket_1_doorcount</c></remarks>
public sealed class DecayBracket1DoorcountCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.bracket_1_doorcount";

    /// <summary>Reads the current value of <c>decay.bracket_1_doorcount</c>.</summary>
    public static DecayBracket1DoorcountCommand CreateGet()
    {
        var cmd = CreatePackage<DecayBracket1DoorcountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.bracket_1_doorcount</c> to <paramref name="value"/>.</summary>
    public static DecayBracket1DoorcountCommand CreateSet(int value)
    {
        var cmd = CreatePackage<DecayBracket1DoorcountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
