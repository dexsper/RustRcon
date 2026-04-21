using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Doors in the 3rd upkeep bracket will cost this value per day to maintain</summary>
/// <remarks>Full RCON name: <c>decay.bracket_2_doorfraction</c></remarks>
public sealed class DecayBracket2DoorfractionCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.bracket_2_doorfraction";

    /// <summary>Reads the current value of <c>decay.bracket_2_doorfraction</c>.</summary>
    public static DecayBracket2DoorfractionCommand CreateGet()
    {
        var cmd = CreatePackage<DecayBracket2DoorfractionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.bracket_2_doorfraction</c> to <paramref name="value"/>.</summary>
    public static DecayBracket2DoorfractionCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayBracket2DoorfractionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
