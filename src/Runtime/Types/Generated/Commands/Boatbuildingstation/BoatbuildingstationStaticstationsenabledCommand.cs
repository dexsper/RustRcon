using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>boatbuildingstation.staticstationsenabled</c>.</summary>
/// <remarks>Full RCON name: <c>boatbuildingstation.staticstationsenabled</c></remarks>
public sealed class BoatbuildingstationStaticstationsenabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "boatbuildingstation.staticstationsenabled";

    /// <summary>Reads the current value of <c>boatbuildingstation.staticstationsenabled</c>.</summary>
    public static BoatbuildingstationStaticstationsenabledCommand CreateGet()
    {
        var cmd = CreatePackage<BoatbuildingstationStaticstationsenabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>boatbuildingstation.staticstationsenabled</c> to <paramref name="value"/>.</summary>
    public static BoatbuildingstationStaticstationsenabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<BoatbuildingstationStaticstationsenabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
