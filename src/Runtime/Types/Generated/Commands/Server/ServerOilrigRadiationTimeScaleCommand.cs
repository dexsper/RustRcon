using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Multiplier for how long radiation lingers after an event at oil rig monuments; higher values extend the radiation duration</summary>
/// <remarks>Full RCON name: <c>server.oilrig_radiation_time_scale</c></remarks>
public sealed class ServerOilrigRadiationTimeScaleCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.oilrig_radiation_time_scale";

    /// <summary>Reads the current value of <c>server.oilrig_radiation_time_scale</c>.</summary>
    public static ServerOilrigRadiationTimeScaleCommand CreateGet()
    {
        var cmd = CreatePackage<ServerOilrigRadiationTimeScaleCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.oilrig_radiation_time_scale</c> to <paramref name="value"/>.</summary>
    public static ServerOilrigRadiationTimeScaleCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerOilrigRadiationTimeScaleCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
