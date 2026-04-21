using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.rainbow</c>.</summary>
/// <remarks>Full RCON name: <c>weather.rainbow</c></remarks>
public sealed class WeatherRainbowCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.rainbow";

    /// <summary>Reads the current value of <c>weather.rainbow</c>.</summary>
    public static WeatherRainbowCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherRainbowCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.rainbow</c> to <paramref name="value"/>.</summary>
    public static WeatherRainbowCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherRainbowCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
