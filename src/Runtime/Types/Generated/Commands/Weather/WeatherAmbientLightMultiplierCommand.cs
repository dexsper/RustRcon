using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.ambient_light_multiplier</c>.</summary>
/// <remarks>Full RCON name: <c>weather.ambient_light_multiplier</c></remarks>
public sealed class WeatherAmbientLightMultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.ambient_light_multiplier";

    /// <summary>Reads the current value of <c>weather.ambient_light_multiplier</c>.</summary>
    public static WeatherAmbientLightMultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherAmbientLightMultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.ambient_light_multiplier</c> to <paramref name="value"/>.</summary>
    public static WeatherAmbientLightMultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherAmbientLightMultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
