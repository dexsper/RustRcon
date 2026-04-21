using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.biome_fog_ambient_saturation_mult</c>.</summary>
/// <remarks>Full RCON name: <c>weather.biome_fog_ambient_saturation_mult</c></remarks>
public sealed class WeatherBiomeFogAmbientSaturationMultCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.biome_fog_ambient_saturation_mult";

    /// <summary>Reads the current value of <c>weather.biome_fog_ambient_saturation_mult</c>.</summary>
    public static WeatherBiomeFogAmbientSaturationMultCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherBiomeFogAmbientSaturationMultCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.biome_fog_ambient_saturation_mult</c> to <paramref name="value"/>.</summary>
    public static WeatherBiomeFogAmbientSaturationMultCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherBiomeFogAmbientSaturationMultCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
