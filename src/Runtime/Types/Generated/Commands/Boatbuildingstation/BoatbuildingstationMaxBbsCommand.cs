using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>boatbuildingstation.max_bbs</c>.</summary>
/// <remarks>Full RCON name: <c>boatbuildingstation.max_bbs</c></remarks>
public sealed class BoatbuildingstationMaxBbsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "boatbuildingstation.max_bbs";

    /// <summary>Reads the current value of <c>boatbuildingstation.max_bbs</c>.</summary>
    public static BoatbuildingstationMaxBbsCommand CreateGet()
    {
        var cmd = CreatePackage<BoatbuildingstationMaxBbsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>boatbuildingstation.max_bbs</c> to <paramref name="value"/>.</summary>
    public static BoatbuildingstationMaxBbsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<BoatbuildingstationMaxBbsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
