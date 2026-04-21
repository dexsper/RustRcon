using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.rain</c>.</summary>
/// <remarks>Full RCON name: <c>weather.rain</c></remarks>
public sealed class WeatherRainCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.rain";

    /// <summary>Reads the current value of <c>weather.rain</c>.</summary>
    public static WeatherRainCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherRainCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.rain</c> to <paramref name="value"/>.</summary>
    public static WeatherRainCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherRainCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
