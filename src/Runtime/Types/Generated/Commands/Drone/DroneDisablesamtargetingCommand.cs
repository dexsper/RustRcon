using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>drone.disablesamtargeting</c>.</summary>
/// <remarks>Full RCON name: <c>drone.disablesamtargeting</c></remarks>
public sealed class DroneDisablesamtargetingCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "drone.disablesamtargeting";

    /// <summary>Reads the current value of <c>drone.disablesamtargeting</c>.</summary>
    public static DroneDisablesamtargetingCommand CreateGet()
    {
        var cmd = CreatePackage<DroneDisablesamtargetingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>drone.disablesamtargeting</c> to <paramref name="value"/>.</summary>
    public static DroneDisablesamtargetingCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<DroneDisablesamtargetingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
