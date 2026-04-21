using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.ocean_time</c>.</summary>
/// <remarks>Full RCON name: <c>weather.ocean_time</c></remarks>
public sealed class WeatherOceanTimeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.ocean_time";

    /// <summary>Reads the current value of <c>weather.ocean_time</c>.</summary>
    public static WeatherOceanTimeCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherOceanTimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.ocean_time</c> to <paramref name="value"/>.</summary>
    public static WeatherOceanTimeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherOceanTimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
