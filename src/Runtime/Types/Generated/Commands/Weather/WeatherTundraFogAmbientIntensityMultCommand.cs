using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.tundra_fog_ambient_intensity_mult</c>.</summary>
/// <remarks>Full RCON name: <c>weather.tundra_fog_ambient_intensity_mult</c></remarks>
public sealed class WeatherTundraFogAmbientIntensityMultCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.tundra_fog_ambient_intensity_mult";

    /// <summary>Reads the current value of <c>weather.tundra_fog_ambient_intensity_mult</c>.</summary>
    public static WeatherTundraFogAmbientIntensityMultCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherTundraFogAmbientIntensityMultCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.tundra_fog_ambient_intensity_mult</c> to <paramref name="value"/>.</summary>
    public static WeatherTundraFogAmbientIntensityMultCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherTundraFogAmbientIntensityMultCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
