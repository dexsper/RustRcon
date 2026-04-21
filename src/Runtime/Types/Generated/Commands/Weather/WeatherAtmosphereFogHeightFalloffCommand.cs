using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.atmosphere_fog_height_falloff</c>.</summary>
/// <remarks>Full RCON name: <c>weather.atmosphere_fog_height_falloff</c></remarks>
public sealed class WeatherAtmosphereFogHeightFalloffCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.atmosphere_fog_height_falloff";

    /// <summary>Reads the current value of <c>weather.atmosphere_fog_height_falloff</c>.</summary>
    public static WeatherAtmosphereFogHeightFalloffCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherAtmosphereFogHeightFalloffCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.atmosphere_fog_height_falloff</c> to <paramref name="value"/>.</summary>
    public static WeatherAtmosphereFogHeightFalloffCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherAtmosphereFogHeightFalloffCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
