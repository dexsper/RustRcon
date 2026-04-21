using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Controls how wet surfaces become during snow; affects surface wetness shaders independently from rain wetness</summary>
/// <remarks>Full RCON name: <c>weather.wetness_snow</c></remarks>
public sealed class WeatherWetnessSnowCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.wetness_snow";

    /// <summary>Reads the current value of <c>weather.wetness_snow</c>.</summary>
    public static WeatherWetnessSnowCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherWetnessSnowCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.wetness_snow</c> to <paramref name="value"/>.</summary>
    public static WeatherWetnessSnowCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherWetnessSnowCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
