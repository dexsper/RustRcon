using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>boatbuildingblock.alwayrotatable</c>.</summary>
/// <remarks>Full RCON name: <c>boatbuildingblock.alwayrotatable</c></remarks>
public sealed class BoatbuildingblockAlwayrotatableCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "boatbuildingblock.alwayrotatable";

    /// <summary>Reads the current value of <c>boatbuildingblock.alwayrotatable</c>.</summary>
    public static BoatbuildingblockAlwayrotatableCommand CreateGet()
    {
        var cmd = CreatePackage<BoatbuildingblockAlwayrotatableCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>boatbuildingblock.alwayrotatable</c> to <paramref name="value"/>.</summary>
    public static BoatbuildingblockAlwayrotatableCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<BoatbuildingblockAlwayrotatableCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
