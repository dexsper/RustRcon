using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Multiplied by the base BuildingBlockDecay duration</summary>
/// <remarks>Full RCON name: <c>boatbuildingblockdecay.decaydurationmultiplier</c></remarks>
public sealed class BoatbuildingblockdecayDecaydurationmultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "boatbuildingblockdecay.decaydurationmultiplier";

    /// <summary>Reads the current value of <c>boatbuildingblockdecay.decaydurationmultiplier</c>.</summary>
    public static BoatbuildingblockdecayDecaydurationmultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<BoatbuildingblockdecayDecaydurationmultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>boatbuildingblockdecay.decaydurationmultiplier</c> to <paramref name="value"/>.</summary>
    public static BoatbuildingblockdecayDecaydurationmultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BoatbuildingblockdecayDecaydurationmultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
