using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.cloud_brightness</c>.</summary>
/// <remarks>Full RCON name: <c>weather.cloud_brightness</c></remarks>
public sealed class WeatherCloudBrightnessCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.cloud_brightness";

    /// <summary>Reads the current value of <c>weather.cloud_brightness</c>.</summary>
    public static WeatherCloudBrightnessCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherCloudBrightnessCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.cloud_brightness</c> to <paramref name="value"/>.</summary>
    public static WeatherCloudBrightnessCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherCloudBrightnessCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
