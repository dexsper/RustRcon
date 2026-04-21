using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Multiplier for radiation intensity inside oil rig monuments; higher values increase radiation damage per second</summary>
/// <remarks>Full RCON name: <c>server.oilrig_radiation_amount_scale</c></remarks>
public sealed class ServerOilrigRadiationAmountScaleCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.oilrig_radiation_amount_scale";

    /// <summary>Reads the current value of <c>server.oilrig_radiation_amount_scale</c>.</summary>
    public static ServerOilrigRadiationAmountScaleCommand CreateGet()
    {
        var cmd = CreatePackage<ServerOilrigRadiationAmountScaleCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.oilrig_radiation_amount_scale</c> to <paramref name="value"/>.</summary>
    public static ServerOilrigRadiationAmountScaleCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerOilrigRadiationAmountScaleCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
