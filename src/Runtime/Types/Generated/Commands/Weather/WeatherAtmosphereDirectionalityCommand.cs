using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.atmosphere_directionality</c>.</summary>
/// <remarks>Full RCON name: <c>weather.atmosphere_directionality</c></remarks>
public sealed class WeatherAtmosphereDirectionalityCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.atmosphere_directionality";

    /// <summary>Reads the current value of <c>weather.atmosphere_directionality</c>.</summary>
    public static WeatherAtmosphereDirectionalityCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherAtmosphereDirectionalityCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.atmosphere_directionality</c> to <paramref name="value"/>.</summary>
    public static WeatherAtmosphereDirectionalityCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherAtmosphereDirectionalityCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
