using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.jungle_fog_ambient_intensity_mult</c>.</summary>
/// <remarks>Full RCON name: <c>weather.jungle_fog_ambient_intensity_mult</c></remarks>
public sealed class WeatherJungleFogAmbientIntensityMultCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.jungle_fog_ambient_intensity_mult";

    /// <summary>Reads the current value of <c>weather.jungle_fog_ambient_intensity_mult</c>.</summary>
    public static WeatherJungleFogAmbientIntensityMultCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherJungleFogAmbientIntensityMultCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.jungle_fog_ambient_intensity_mult</c> to <paramref name="value"/>.</summary>
    public static WeatherJungleFogAmbientIntensityMultCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherJungleFogAmbientIntensityMultCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
