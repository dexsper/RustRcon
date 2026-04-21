using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The number of blocks in the 3rd upkeep bracket</summary>
/// <remarks>Full RCON name: <c>decay.bracket_2_blockcount</c></remarks>
public sealed class DecayBracket2BlockcountCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.bracket_2_blockcount";

    /// <summary>Reads the current value of <c>decay.bracket_2_blockcount</c>.</summary>
    public static DecayBracket2BlockcountCommand CreateGet()
    {
        var cmd = CreatePackage<DecayBracket2BlockcountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.bracket_2_blockcount</c> to <paramref name="value"/>.</summary>
    public static DecayBracket2BlockcountCommand CreateSet(int value)
    {
        var cmd = CreatePackage<DecayBracket2BlockcountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
