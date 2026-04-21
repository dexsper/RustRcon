using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.arctic_fog_light_boost_mult</c>.</summary>
/// <remarks>Full RCON name: <c>weather.arctic_fog_light_boost_mult</c></remarks>
public sealed class WeatherArcticFogLightBoostMultCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.arctic_fog_light_boost_mult";

    /// <summary>Reads the current value of <c>weather.arctic_fog_light_boost_mult</c>.</summary>
    public static WeatherArcticFogLightBoostMultCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherArcticFogLightBoostMultCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.arctic_fog_light_boost_mult</c> to <paramref name="value"/>.</summary>
    public static WeatherArcticFogLightBoostMultCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherArcticFogLightBoostMultCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
