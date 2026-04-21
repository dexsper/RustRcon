using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The number of doors in the 3rd upkeep bracket</summary>
/// <remarks>Full RCON name: <c>decay.bracket_2_doorcount</c></remarks>
public sealed class DecayBracket2DoorcountCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.bracket_2_doorcount";

    /// <summary>Reads the current value of <c>decay.bracket_2_doorcount</c>.</summary>
    public static DecayBracket2DoorcountCommand CreateGet()
    {
        var cmd = CreatePackage<DecayBracket2DoorcountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.bracket_2_doorcount</c> to <paramref name="value"/>.</summary>
    public static DecayBracket2DoorcountCommand CreateSet(int value)
    {
        var cmd = CreatePackage<DecayBracket2DoorcountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
