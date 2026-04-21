using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>boatbuildingstation.autocloseplayercheckinterval</c>.</summary>
/// <remarks>Full RCON name: <c>boatbuildingstation.autocloseplayercheckinterval</c></remarks>
public sealed class BoatbuildingstationAutocloseplayercheckintervalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "boatbuildingstation.autocloseplayercheckinterval";

    /// <summary>Reads the current value of <c>boatbuildingstation.autocloseplayercheckinterval</c>.</summary>
    public static BoatbuildingstationAutocloseplayercheckintervalCommand CreateGet()
    {
        var cmd = CreatePackage<BoatbuildingstationAutocloseplayercheckintervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>boatbuildingstation.autocloseplayercheckinterval</c> to <paramref name="value"/>.</summary>
    public static BoatbuildingstationAutocloseplayercheckintervalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BoatbuildingstationAutocloseplayercheckintervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
