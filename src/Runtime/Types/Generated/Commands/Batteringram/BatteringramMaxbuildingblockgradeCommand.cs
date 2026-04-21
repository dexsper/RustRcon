using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum building block upgrade grade (0=twig,1=wood,2=stone,3=metal,4=top tier) that the battering ram can damage; default 2 (stone)</summary>
/// <remarks>Full RCON name: <c>batteringram.maxbuildingblockgrade</c></remarks>
public sealed class BatteringramMaxbuildingblockgradeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "batteringram.maxbuildingblockgrade";

    /// <summary>Reads the current value of <c>batteringram.maxbuildingblockgrade</c>.</summary>
    public static BatteringramMaxbuildingblockgradeCommand CreateGet()
    {
        var cmd = CreatePackage<BatteringramMaxbuildingblockgradeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>batteringram.maxbuildingblockgrade</c> to <paramref name="value"/>.</summary>
    public static BatteringramMaxbuildingblockgradeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<BatteringramMaxbuildingblockgradeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
