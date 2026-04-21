using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.storm_chance</c>.</summary>
/// <remarks>Full RCON name: <c>weather.storm_chance</c></remarks>
public sealed class WeatherStormChanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.storm_chance";

    /// <summary>Reads the current value of <c>weather.storm_chance</c>.</summary>
    public static WeatherStormChanceCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherStormChanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.storm_chance</c> to <paramref name="value"/>.</summary>
    public static WeatherStormChanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherStormChanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
