using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, damage dealt to a building block attached to a boat is forwarded up to the parent boat entity</summary>
/// <remarks>Full RCON name: <c>boatbuildingblock.forwarddamagetoparentboat</c></remarks>
public sealed class BoatbuildingblockForwarddamagetoparentboatCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "boatbuildingblock.forwarddamagetoparentboat";

    /// <summary>Reads the current value of <c>boatbuildingblock.forwarddamagetoparentboat</c>.</summary>
    public static BoatbuildingblockForwarddamagetoparentboatCommand CreateGet()
    {
        var cmd = CreatePackage<BoatbuildingblockForwarddamagetoparentboatCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>boatbuildingblock.forwarddamagetoparentboat</c> to <paramref name="value"/>.</summary>
    public static BoatbuildingblockForwarddamagetoparentboatCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<BoatbuildingblockForwarddamagetoparentboatCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
