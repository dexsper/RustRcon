using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Maximum difference in velocity for train cars to couple</summary>
/// <remarks>Full RCON name: <c>traincouplingcontroller.max_couple_speed</c></remarks>
public sealed class TraincouplingcontrollerMaxCoupleSpeedCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "traincouplingcontroller.max_couple_speed";

    /// <summary>Reads the current value of <c>traincouplingcontroller.max_couple_speed</c>.</summary>
    public static TraincouplingcontrollerMaxCoupleSpeedCommand CreateGet()
    {
        var cmd = CreatePackage<TraincouplingcontrollerMaxCoupleSpeedCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>traincouplingcontroller.max_couple_speed</c> to <paramref name="value"/>.</summary>
    public static TraincouplingcontrollerMaxCoupleSpeedCommand CreateSet(float value)
    {
        var cmd = CreatePackage<TraincouplingcontrollerMaxCoupleSpeedCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
