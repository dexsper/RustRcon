using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.jungle_fog_light_boost_mult</c>.</summary>
/// <remarks>Full RCON name: <c>weather.jungle_fog_light_boost_mult</c></remarks>
public sealed class WeatherJungleFogLightBoostMultCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.jungle_fog_light_boost_mult";

    /// <summary>Reads the current value of <c>weather.jungle_fog_light_boost_mult</c>.</summary>
    public static WeatherJungleFogLightBoostMultCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherJungleFogLightBoostMultCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.jungle_fog_light_boost_mult</c> to <paramref name="value"/>.</summary>
    public static WeatherJungleFogLightBoostMultCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherJungleFogLightBoostMultCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
