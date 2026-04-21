using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.atmosphere_fog_ramp_start_distance</c>.</summary>
/// <remarks>Full RCON name: <c>weather.atmosphere_fog_ramp_start_distance</c></remarks>
public sealed class WeatherAtmosphereFogRampStartDistanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.atmosphere_fog_ramp_start_distance";

    /// <summary>Reads the current value of <c>weather.atmosphere_fog_ramp_start_distance</c>.</summary>
    public static WeatherAtmosphereFogRampStartDistanceCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherAtmosphereFogRampStartDistanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.atmosphere_fog_ramp_start_distance</c> to <paramref name="value"/>.</summary>
    public static WeatherAtmosphereFogRampStartDistanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherAtmosphereFogRampStartDistanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
