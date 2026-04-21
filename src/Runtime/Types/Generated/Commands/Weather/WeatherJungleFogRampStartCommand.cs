using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.jungle_fog_ramp_start</c>.</summary>
/// <remarks>Full RCON name: <c>weather.jungle_fog_ramp_start</c></remarks>
public sealed class WeatherJungleFogRampStartCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.jungle_fog_ramp_start";

    /// <summary>Reads the current value of <c>weather.jungle_fog_ramp_start</c>.</summary>
    public static WeatherJungleFogRampStartCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherJungleFogRampStartCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.jungle_fog_ramp_start</c> to <paramref name="value"/>.</summary>
    public static WeatherJungleFogRampStartCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherJungleFogRampStartCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
