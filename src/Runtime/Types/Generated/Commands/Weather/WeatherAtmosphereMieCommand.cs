using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.atmosphere_mie</c>.</summary>
/// <remarks>Full RCON name: <c>weather.atmosphere_mie</c></remarks>
public sealed class WeatherAtmosphereMieCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.atmosphere_mie";

    /// <summary>Reads the current value of <c>weather.atmosphere_mie</c>.</summary>
    public static WeatherAtmosphereMieCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherAtmosphereMieCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.atmosphere_mie</c> to <paramref name="value"/>.</summary>
    public static WeatherAtmosphereMieCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherAtmosphereMieCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
