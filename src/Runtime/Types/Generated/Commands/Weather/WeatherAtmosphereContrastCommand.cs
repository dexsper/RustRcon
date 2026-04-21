using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.atmosphere_contrast</c>.</summary>
/// <remarks>Full RCON name: <c>weather.atmosphere_contrast</c></remarks>
public sealed class WeatherAtmosphereContrastCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.atmosphere_contrast";

    /// <summary>Reads the current value of <c>weather.atmosphere_contrast</c>.</summary>
    public static WeatherAtmosphereContrastCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherAtmosphereContrastCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.atmosphere_contrast</c> to <paramref name="value"/>.</summary>
    public static WeatherAtmosphereContrastCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherAtmosphereContrastCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
