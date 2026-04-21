using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Number of blocks in the 2nd upkeep bracket</summary>
/// <remarks>Full RCON name: <c>decay.bracket_1_blockcount</c></remarks>
public sealed class DecayBracket1BlockcountCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.bracket_1_blockcount";

    /// <summary>Reads the current value of <c>decay.bracket_1_blockcount</c>.</summary>
    public static DecayBracket1BlockcountCommand CreateGet()
    {
        var cmd = CreatePackage<DecayBracket1BlockcountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.bracket_1_blockcount</c> to <paramref name="value"/>.</summary>
    public static DecayBracket1BlockcountCommand CreateSet(int value)
    {
        var cmd = CreatePackage<DecayBracket1BlockcountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
