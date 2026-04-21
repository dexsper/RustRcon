using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>boatbuildingblock.alwaysdemolishable</c>.</summary>
/// <remarks>Full RCON name: <c>boatbuildingblock.alwaysdemolishable</c></remarks>
public sealed class BoatbuildingblockAlwaysdemolishableCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "boatbuildingblock.alwaysdemolishable";

    /// <summary>Reads the current value of <c>boatbuildingblock.alwaysdemolishable</c>.</summary>
    public static BoatbuildingblockAlwaysdemolishableCommand CreateGet()
    {
        var cmd = CreatePackage<BoatbuildingblockAlwaysdemolishableCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>boatbuildingblock.alwaysdemolishable</c> to <paramref name="value"/>.</summary>
    public static BoatbuildingblockAlwaysdemolishableCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<BoatbuildingblockAlwaysdemolishableCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
