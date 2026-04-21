using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.speedhack_water_threshold</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.speedhack_water_threshold</c></remarks>
public sealed class AntihackSpeedhackWaterThresholdCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.speedhack_water_threshold";

    /// <summary>Reads the current value of <c>antihack.speedhack_water_threshold</c>.</summary>
    public static AntihackSpeedhackWaterThresholdCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackSpeedhackWaterThresholdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.speedhack_water_threshold</c> to <paramref name="value"/>.</summary>
    public static AntihackSpeedhackWaterThresholdCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackSpeedhackWaterThresholdCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
