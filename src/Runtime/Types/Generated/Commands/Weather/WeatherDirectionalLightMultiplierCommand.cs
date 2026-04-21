using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.directional_light_multiplier</c>.</summary>
/// <remarks>Full RCON name: <c>weather.directional_light_multiplier</c></remarks>
public sealed class WeatherDirectionalLightMultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.directional_light_multiplier";

    /// <summary>Reads the current value of <c>weather.directional_light_multiplier</c>.</summary>
    public static WeatherDirectionalLightMultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherDirectionalLightMultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.directional_light_multiplier</c> to <paramref name="value"/>.</summary>
    public static WeatherDirectionalLightMultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherDirectionalLightMultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
