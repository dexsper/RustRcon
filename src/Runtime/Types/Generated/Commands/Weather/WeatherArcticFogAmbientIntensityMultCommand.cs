using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.arctic_fog_ambient_intensity_mult</c>.</summary>
/// <remarks>Full RCON name: <c>weather.arctic_fog_ambient_intensity_mult</c></remarks>
public sealed class WeatherArcticFogAmbientIntensityMultCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.arctic_fog_ambient_intensity_mult";

    /// <summary>Reads the current value of <c>weather.arctic_fog_ambient_intensity_mult</c>.</summary>
    public static WeatherArcticFogAmbientIntensityMultCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherArcticFogAmbientIntensityMultCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.arctic_fog_ambient_intensity_mult</c> to <paramref name="value"/>.</summary>
    public static WeatherArcticFogAmbientIntensityMultCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherArcticFogAmbientIntensityMultCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
