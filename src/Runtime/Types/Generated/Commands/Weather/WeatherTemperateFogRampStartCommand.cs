using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.temperate_fog_ramp_start</c>.</summary>
/// <remarks>Full RCON name: <c>weather.temperate_fog_ramp_start</c></remarks>
public sealed class WeatherTemperateFogRampStartCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.temperate_fog_ramp_start";

    /// <summary>Reads the current value of <c>weather.temperate_fog_ramp_start</c>.</summary>
    public static WeatherTemperateFogRampStartCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherTemperateFogRampStartCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.temperate_fog_ramp_start</c> to <paramref name="value"/>.</summary>
    public static WeatherTemperateFogRampStartCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherTemperateFogRampStartCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
