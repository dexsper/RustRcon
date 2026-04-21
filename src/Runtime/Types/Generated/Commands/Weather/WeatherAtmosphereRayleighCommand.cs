using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.atmosphere_rayleigh</c>.</summary>
/// <remarks>Full RCON name: <c>weather.atmosphere_rayleigh</c></remarks>
public sealed class WeatherAtmosphereRayleighCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.atmosphere_rayleigh";

    /// <summary>Reads the current value of <c>weather.atmosphere_rayleigh</c>.</summary>
    public static WeatherAtmosphereRayleighCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherAtmosphereRayleighCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.atmosphere_rayleigh</c> to <paramref name="value"/>.</summary>
    public static WeatherAtmosphereRayleighCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherAtmosphereRayleighCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
