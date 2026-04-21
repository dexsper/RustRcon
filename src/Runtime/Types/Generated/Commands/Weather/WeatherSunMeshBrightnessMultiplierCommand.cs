using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.sun_mesh_brightness_multiplier</c>.</summary>
/// <remarks>Full RCON name: <c>weather.sun_mesh_brightness_multiplier</c></remarks>
public sealed class WeatherSunMeshBrightnessMultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.sun_mesh_brightness_multiplier";

    /// <summary>Reads the current value of <c>weather.sun_mesh_brightness_multiplier</c>.</summary>
    public static WeatherSunMeshBrightnessMultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherSunMeshBrightnessMultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.sun_mesh_brightness_multiplier</c> to <paramref name="value"/>.</summary>
    public static WeatherSunMeshBrightnessMultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherSunMeshBrightnessMultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
