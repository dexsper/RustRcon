using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.arid_fog_ramp_end</c>.</summary>
/// <remarks>Full RCON name: <c>weather.arid_fog_ramp_end</c></remarks>
public sealed class WeatherAridFogRampEndCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.arid_fog_ramp_end";

    /// <summary>Reads the current value of <c>weather.arid_fog_ramp_end</c>.</summary>
    public static WeatherAridFogRampEndCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherAridFogRampEndCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.arid_fog_ramp_end</c> to <paramref name="value"/>.</summary>
    public static WeatherAridFogRampEndCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherAridFogRampEndCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
