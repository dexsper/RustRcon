using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.arctic_fog_ramp_end</c>.</summary>
/// <remarks>Full RCON name: <c>weather.arctic_fog_ramp_end</c></remarks>
public sealed class WeatherArcticFogRampEndCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.arctic_fog_ramp_end";

    /// <summary>Reads the current value of <c>weather.arctic_fog_ramp_end</c>.</summary>
    public static WeatherArcticFogRampEndCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherArcticFogRampEndCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.arctic_fog_ramp_end</c> to <paramref name="value"/>.</summary>
    public static WeatherArcticFogRampEndCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherArcticFogRampEndCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
