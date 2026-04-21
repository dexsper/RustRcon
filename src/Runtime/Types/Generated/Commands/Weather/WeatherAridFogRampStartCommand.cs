using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.arid_fog_ramp_start</c>.</summary>
/// <remarks>Full RCON name: <c>weather.arid_fog_ramp_start</c></remarks>
public sealed class WeatherAridFogRampStartCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.arid_fog_ramp_start";

    /// <summary>Reads the current value of <c>weather.arid_fog_ramp_start</c>.</summary>
    public static WeatherAridFogRampStartCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherAridFogRampStartCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.arid_fog_ramp_start</c> to <paramref name="value"/>.</summary>
    public static WeatherAridFogRampStartCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherAridFogRampStartCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
