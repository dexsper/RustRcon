using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.temperate_fog_ramp_end</c>.</summary>
/// <remarks>Full RCON name: <c>weather.temperate_fog_ramp_end</c></remarks>
public sealed class WeatherTemperateFogRampEndCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.temperate_fog_ramp_end";

    /// <summary>Reads the current value of <c>weather.temperate_fog_ramp_end</c>.</summary>
    public static WeatherTemperateFogRampEndCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherTemperateFogRampEndCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.temperate_fog_ramp_end</c> to <paramref name="value"/>.</summary>
    public static WeatherTemperateFogRampEndCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherTemperateFogRampEndCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
