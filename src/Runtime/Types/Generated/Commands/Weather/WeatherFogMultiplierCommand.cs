using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.fog_multiplier</c>.</summary>
/// <remarks>Full RCON name: <c>weather.fog_multiplier</c></remarks>
public sealed class WeatherFogMultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.fog_multiplier";

    /// <summary>Reads the current value of <c>weather.fog_multiplier</c>.</summary>
    public static WeatherFogMultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherFogMultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.fog_multiplier</c> to <paramref name="value"/>.</summary>
    public static WeatherFogMultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherFogMultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
