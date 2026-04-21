using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.wind</c>.</summary>
/// <remarks>Full RCON name: <c>weather.wind</c></remarks>
public sealed class WeatherWindCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.wind";

    /// <summary>Reads the current value of <c>weather.wind</c>.</summary>
    public static WeatherWindCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherWindCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.wind</c> to <paramref name="value"/>.</summary>
    public static WeatherWindCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherWindCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
