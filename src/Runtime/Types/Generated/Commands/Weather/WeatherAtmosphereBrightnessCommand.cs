using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.atmosphere_brightness</c>.</summary>
/// <remarks>Full RCON name: <c>weather.atmosphere_brightness</c></remarks>
public sealed class WeatherAtmosphereBrightnessCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.atmosphere_brightness";

    /// <summary>Reads the current value of <c>weather.atmosphere_brightness</c>.</summary>
    public static WeatherAtmosphereBrightnessCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherAtmosphereBrightnessCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.atmosphere_brightness</c> to <paramref name="value"/>.</summary>
    public static WeatherAtmosphereBrightnessCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherAtmosphereBrightnessCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
