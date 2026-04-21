using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.tundra_fog_ramp_start</c>.</summary>
/// <remarks>Full RCON name: <c>weather.tundra_fog_ramp_start</c></remarks>
public sealed class WeatherTundraFogRampStartCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.tundra_fog_ramp_start";

    /// <summary>Reads the current value of <c>weather.tundra_fog_ramp_start</c>.</summary>
    public static WeatherTundraFogRampStartCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherTundraFogRampStartCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.tundra_fog_ramp_start</c> to <paramref name="value"/>.</summary>
    public static WeatherTundraFogRampStartCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherTundraFogRampStartCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
