using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.arctic_fog_ramp_start</c>.</summary>
/// <remarks>Full RCON name: <c>weather.arctic_fog_ramp_start</c></remarks>
public sealed class WeatherArcticFogRampStartCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.arctic_fog_ramp_start";

    /// <summary>Reads the current value of <c>weather.arctic_fog_ramp_start</c>.</summary>
    public static WeatherArcticFogRampStartCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherArcticFogRampStartCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.arctic_fog_ramp_start</c> to <paramref name="value"/>.</summary>
    public static WeatherArcticFogRampStartCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherArcticFogRampStartCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
