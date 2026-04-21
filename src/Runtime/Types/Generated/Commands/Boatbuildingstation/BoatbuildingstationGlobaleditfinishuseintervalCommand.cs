using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>boatbuildingstation.globaleditfinishuseinterval</c>.</summary>
/// <remarks>Full RCON name: <c>boatbuildingstation.globaleditfinishuseinterval</c></remarks>
public sealed class BoatbuildingstationGlobaleditfinishuseintervalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "boatbuildingstation.globaleditfinishuseinterval";

    /// <summary>Reads the current value of <c>boatbuildingstation.globaleditfinishuseinterval</c>.</summary>
    public static BoatbuildingstationGlobaleditfinishuseintervalCommand CreateGet()
    {
        var cmd = CreatePackage<BoatbuildingstationGlobaleditfinishuseintervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>boatbuildingstation.globaleditfinishuseinterval</c> to <paramref name="value"/>.</summary>
    public static BoatbuildingstationGlobaleditfinishuseintervalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BoatbuildingstationGlobaleditfinishuseintervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
