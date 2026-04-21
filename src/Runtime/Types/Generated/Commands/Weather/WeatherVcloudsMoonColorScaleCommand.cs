using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.vclouds_moon_color_scale</c>.</summary>
/// <remarks>Full RCON name: <c>weather.vclouds_moon_color_scale</c></remarks>
public sealed class WeatherVcloudsMoonColorScaleCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.vclouds_moon_color_scale";

    /// <summary>Reads the current value of <c>weather.vclouds_moon_color_scale</c>.</summary>
    public static WeatherVcloudsMoonColorScaleCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherVcloudsMoonColorScaleCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.vclouds_moon_color_scale</c> to <paramref name="value"/>.</summary>
    public static WeatherVcloudsMoonColorScaleCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherVcloudsMoonColorScaleCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
