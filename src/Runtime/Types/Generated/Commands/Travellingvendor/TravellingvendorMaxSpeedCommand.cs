using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>travellingvendor.max_speed</c>.</summary>
/// <remarks>Full RCON name: <c>travellingvendor.max_speed</c></remarks>
public sealed class TravellingvendorMaxSpeedCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "travellingvendor.max_speed";

    /// <summary>Reads the current value of <c>travellingvendor.max_speed</c>.</summary>
    public static TravellingvendorMaxSpeedCommand CreateGet()
    {
        var cmd = CreatePackage<TravellingvendorMaxSpeedCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>travellingvendor.max_speed</c> to <paramref name="value"/>.</summary>
    public static TravellingvendorMaxSpeedCommand CreateSet(float value)
    {
        var cmd = CreatePackage<TravellingvendorMaxSpeedCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
