using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Multiplied by the base BuildingBlockDecay duration</summary>
/// <remarks>Full RCON name: <c>boatbuildingblockdecay.decaydelayminutes</c></remarks>
public sealed class BoatbuildingblockdecayDecaydelayminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "boatbuildingblockdecay.decaydelayminutes";

    /// <summary>Reads the current value of <c>boatbuildingblockdecay.decaydelayminutes</c>.</summary>
    public static BoatbuildingblockdecayDecaydelayminutesCommand CreateGet()
    {
        var cmd = CreatePackage<BoatbuildingblockdecayDecaydelayminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>boatbuildingblockdecay.decaydelayminutes</c> to <paramref name="value"/>.</summary>
    public static BoatbuildingblockdecayDecaydelayminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BoatbuildingblockdecayDecaydelayminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
