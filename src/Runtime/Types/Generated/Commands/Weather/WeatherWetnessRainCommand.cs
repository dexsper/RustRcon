using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Controls how wet surfaces become during rain; higher values cause characters and world objects to appear more soaked when it is raining</summary>
/// <remarks>Full RCON name: <c>weather.wetness_rain</c></remarks>
public sealed class WeatherWetnessRainCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.wetness_rain";

    /// <summary>Reads the current value of <c>weather.wetness_rain</c>.</summary>
    public static WeatherWetnessRainCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherWetnessRainCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.wetness_rain</c> to <paramref name="value"/>.</summary>
    public static WeatherWetnessRainCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherWetnessRainCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
