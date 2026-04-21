using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.cloud_saturation</c>.</summary>
/// <remarks>Full RCON name: <c>weather.cloud_saturation</c></remarks>
public sealed class WeatherCloudSaturationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.cloud_saturation";

    /// <summary>Reads the current value of <c>weather.cloud_saturation</c>.</summary>
    public static WeatherCloudSaturationCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherCloudSaturationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.cloud_saturation</c> to <paramref name="value"/>.</summary>
    public static WeatherCloudSaturationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherCloudSaturationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
