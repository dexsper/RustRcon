using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Number of blocks in the 1st upkeep bracket</summary>
/// <remarks>Full RCON name: <c>decay.bracket_0_blockcount</c></remarks>
public sealed class DecayBracket0BlockcountCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.bracket_0_blockcount";

    /// <summary>Reads the current value of <c>decay.bracket_0_blockcount</c>.</summary>
    public static DecayBracket0BlockcountCommand CreateGet()
    {
        var cmd = CreatePackage<DecayBracket0BlockcountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.bracket_0_blockcount</c> to <paramref name="value"/>.</summary>
    public static DecayBracket0BlockcountCommand CreateSet(int value)
    {
        var cmd = CreatePackage<DecayBracket0BlockcountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
