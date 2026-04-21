using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Blocks in the 4th upkeep bracket will cost this value per day to maintain</summary>
/// <remarks>Full RCON name: <c>decay.bracket_3_costfraction</c></remarks>
public sealed class DecayBracket3CostfractionCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.bracket_3_costfraction";

    /// <summary>Reads the current value of <c>decay.bracket_3_costfraction</c>.</summary>
    public static DecayBracket3CostfractionCommand CreateGet()
    {
        var cmd = CreatePackage<DecayBracket3CostfractionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.bracket_3_costfraction</c> to <paramref name="value"/>.</summary>
    public static DecayBracket3CostfractionCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayBracket3CostfractionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
