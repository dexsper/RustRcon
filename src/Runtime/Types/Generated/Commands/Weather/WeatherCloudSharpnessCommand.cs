using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.cloud_sharpness</c>.</summary>
/// <remarks>Full RCON name: <c>weather.cloud_sharpness</c></remarks>
public sealed class WeatherCloudSharpnessCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.cloud_sharpness";

    /// <summary>Reads the current value of <c>weather.cloud_sharpness</c>.</summary>
    public static WeatherCloudSharpnessCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherCloudSharpnessCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.cloud_sharpness</c> to <paramref name="value"/>.</summary>
    public static WeatherCloudSharpnessCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherCloudSharpnessCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
