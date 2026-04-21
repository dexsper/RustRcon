using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.clear_chance</c>.</summary>
/// <remarks>Full RCON name: <c>weather.clear_chance</c></remarks>
public sealed class WeatherClearChanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.clear_chance";

    /// <summary>Reads the current value of <c>weather.clear_chance</c>.</summary>
    public static WeatherClearChanceCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherClearChanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.clear_chance</c> to <paramref name="value"/>.</summary>
    public static WeatherClearChanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherClearChanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
