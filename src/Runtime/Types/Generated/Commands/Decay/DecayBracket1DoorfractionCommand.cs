using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Doors in the 2nd upkeep bracket will cost this value per day to maintain</summary>
/// <remarks>Full RCON name: <c>decay.bracket_1_doorfraction</c></remarks>
public sealed class DecayBracket1DoorfractionCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.bracket_1_doorfraction";

    /// <summary>Reads the current value of <c>decay.bracket_1_doorfraction</c>.</summary>
    public static DecayBracket1DoorfractionCommand CreateGet()
    {
        var cmd = CreatePackage<DecayBracket1DoorfractionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.bracket_1_doorfraction</c> to <paramref name="value"/>.</summary>
    public static DecayBracket1DoorfractionCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayBracket1DoorfractionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
