using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.fog</c>.</summary>
/// <remarks>Full RCON name: <c>weather.fog</c></remarks>
public sealed class WeatherFogCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.fog";

    /// <summary>Reads the current value of <c>weather.fog</c>.</summary>
    public static WeatherFogCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherFogCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.fog</c> to <paramref name="value"/>.</summary>
    public static WeatherFogCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherFogCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
