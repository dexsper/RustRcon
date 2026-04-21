using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.thunder</c>.</summary>
/// <remarks>Full RCON name: <c>weather.thunder</c></remarks>
public sealed class WeatherThunderCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.thunder";

    /// <summary>Reads the current value of <c>weather.thunder</c>.</summary>
    public static WeatherThunderCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherThunderCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.thunder</c> to <paramref name="value"/>.</summary>
    public static WeatherThunderCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherThunderCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
