using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.atmosphere_fog_ramp_end_distance</c>.</summary>
/// <remarks>Full RCON name: <c>weather.atmosphere_fog_ramp_end_distance</c></remarks>
public sealed class WeatherAtmosphereFogRampEndDistanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.atmosphere_fog_ramp_end_distance";

    /// <summary>Reads the current value of <c>weather.atmosphere_fog_ramp_end_distance</c>.</summary>
    public static WeatherAtmosphereFogRampEndDistanceCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherAtmosphereFogRampEndDistanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.atmosphere_fog_ramp_end_distance</c> to <paramref name="value"/>.</summary>
    public static WeatherAtmosphereFogRampEndDistanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherAtmosphereFogRampEndDistanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
