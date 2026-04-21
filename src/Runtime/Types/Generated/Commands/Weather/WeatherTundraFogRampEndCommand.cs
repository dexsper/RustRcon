using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.tundra_fog_ramp_end</c>.</summary>
/// <remarks>Full RCON name: <c>weather.tundra_fog_ramp_end</c></remarks>
public sealed class WeatherTundraFogRampEndCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.tundra_fog_ramp_end";

    /// <summary>Reads the current value of <c>weather.tundra_fog_ramp_end</c>.</summary>
    public static WeatherTundraFogRampEndCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherTundraFogRampEndCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.tundra_fog_ramp_end</c> to <paramref name="value"/>.</summary>
    public static WeatherTundraFogRampEndCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherTundraFogRampEndCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
