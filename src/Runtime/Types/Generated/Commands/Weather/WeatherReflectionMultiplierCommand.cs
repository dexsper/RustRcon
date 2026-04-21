using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.reflection_multiplier</c>.</summary>
/// <remarks>Full RCON name: <c>weather.reflection_multiplier</c></remarks>
public sealed class WeatherReflectionMultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.reflection_multiplier";

    /// <summary>Reads the current value of <c>weather.reflection_multiplier</c>.</summary>
    public static WeatherReflectionMultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherReflectionMultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.reflection_multiplier</c> to <paramref name="value"/>.</summary>
    public static WeatherReflectionMultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherReflectionMultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
