using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.moon_mesh_brightness_multiplier</c>.</summary>
/// <remarks>Full RCON name: <c>weather.moon_mesh_brightness_multiplier</c></remarks>
public sealed class WeatherMoonMeshBrightnessMultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.moon_mesh_brightness_multiplier";

    /// <summary>Reads the current value of <c>weather.moon_mesh_brightness_multiplier</c>.</summary>
    public static WeatherMoonMeshBrightnessMultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherMoonMeshBrightnessMultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.moon_mesh_brightness_multiplier</c> to <paramref name="value"/>.</summary>
    public static WeatherMoonMeshBrightnessMultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherMoonMeshBrightnessMultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
