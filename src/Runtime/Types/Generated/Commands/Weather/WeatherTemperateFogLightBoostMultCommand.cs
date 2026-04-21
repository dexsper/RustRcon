using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.temperate_fog_light_boost_mult</c>.</summary>
/// <remarks>Full RCON name: <c>weather.temperate_fog_light_boost_mult</c></remarks>
public sealed class WeatherTemperateFogLightBoostMultCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.temperate_fog_light_boost_mult";

    /// <summary>Reads the current value of <c>weather.temperate_fog_light_boost_mult</c>.</summary>
    public static WeatherTemperateFogLightBoostMultCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherTemperateFogLightBoostMultCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.temperate_fog_light_boost_mult</c> to <paramref name="value"/>.</summary>
    public static WeatherTemperateFogLightBoostMultCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherTemperateFogLightBoostMultCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
