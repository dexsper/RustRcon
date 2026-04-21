using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.arid_fog_light_boost_mult</c>.</summary>
/// <remarks>Full RCON name: <c>weather.arid_fog_light_boost_mult</c></remarks>
public sealed class WeatherAridFogLightBoostMultCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.arid_fog_light_boost_mult";

    /// <summary>Reads the current value of <c>weather.arid_fog_light_boost_mult</c>.</summary>
    public static WeatherAridFogLightBoostMultCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherAridFogLightBoostMultCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.arid_fog_light_boost_mult</c> to <paramref name="value"/>.</summary>
    public static WeatherAridFogLightBoostMultCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherAridFogLightBoostMultCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
