using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>boatbuildingstation.editfinishuseinterval</c>.</summary>
/// <remarks>Full RCON name: <c>boatbuildingstation.editfinishuseinterval</c></remarks>
public sealed class BoatbuildingstationEditfinishuseintervalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "boatbuildingstation.editfinishuseinterval";

    /// <summary>Reads the current value of <c>boatbuildingstation.editfinishuseinterval</c>.</summary>
    public static BoatbuildingstationEditfinishuseintervalCommand CreateGet()
    {
        var cmd = CreatePackage<BoatbuildingstationEditfinishuseintervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>boatbuildingstation.editfinishuseinterval</c> to <paramref name="value"/>.</summary>
    public static BoatbuildingstationEditfinishuseintervalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BoatbuildingstationEditfinishuseintervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
