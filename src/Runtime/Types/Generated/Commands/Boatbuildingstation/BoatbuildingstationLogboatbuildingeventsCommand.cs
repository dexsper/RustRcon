using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>boatbuildingstation.logboatbuildingevents</c>.</summary>
/// <remarks>Full RCON name: <c>boatbuildingstation.logboatbuildingevents</c></remarks>
public sealed class BoatbuildingstationLogboatbuildingeventsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "boatbuildingstation.logboatbuildingevents";

    /// <summary>Reads the current value of <c>boatbuildingstation.logboatbuildingevents</c>.</summary>
    public static BoatbuildingstationLogboatbuildingeventsCommand CreateGet()
    {
        var cmd = CreatePackage<BoatbuildingstationLogboatbuildingeventsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>boatbuildingstation.logboatbuildingevents</c> to <paramref name="value"/>.</summary>
    public static BoatbuildingstationLogboatbuildingeventsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<BoatbuildingstationLogboatbuildingeventsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
