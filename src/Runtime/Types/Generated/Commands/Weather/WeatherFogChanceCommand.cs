using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.fog_chance</c>.</summary>
/// <remarks>Full RCON name: <c>weather.fog_chance</c></remarks>
public sealed class WeatherFogChanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.fog_chance";

    /// <summary>Reads the current value of <c>weather.fog_chance</c>.</summary>
    public static WeatherFogChanceCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherFogChanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.fog_chance</c> to <paramref name="value"/>.</summary>
    public static WeatherFogChanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherFogChanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
