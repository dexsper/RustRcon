using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.overcast_chance</c>.</summary>
/// <remarks>Full RCON name: <c>weather.overcast_chance</c></remarks>
public sealed class WeatherOvercastChanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.overcast_chance";

    /// <summary>Reads the current value of <c>weather.overcast_chance</c>.</summary>
    public static WeatherOvercastChanceCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherOvercastChanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.overcast_chance</c> to <paramref name="value"/>.</summary>
    public static WeatherOvercastChanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherOvercastChanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
