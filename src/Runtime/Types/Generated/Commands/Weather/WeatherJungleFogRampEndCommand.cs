using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.jungle_fog_ramp_end</c>.</summary>
/// <remarks>Full RCON name: <c>weather.jungle_fog_ramp_end</c></remarks>
public sealed class WeatherJungleFogRampEndCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.jungle_fog_ramp_end";

    /// <summary>Reads the current value of <c>weather.jungle_fog_ramp_end</c>.</summary>
    public static WeatherJungleFogRampEndCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherJungleFogRampEndCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.jungle_fog_ramp_end</c> to <paramref name="value"/>.</summary>
    public static WeatherJungleFogRampEndCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherJungleFogRampEndCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
