using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.dust_chance</c>.</summary>
/// <remarks>Full RCON name: <c>weather.dust_chance</c></remarks>
public sealed class WeatherDustChanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.dust_chance";

    /// <summary>Reads the current value of <c>weather.dust_chance</c>.</summary>
    public static WeatherDustChanceCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherDustChanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.dust_chance</c> to <paramref name="value"/>.</summary>
    public static WeatherDustChanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherDustChanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
