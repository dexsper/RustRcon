using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.cloud_size</c>.</summary>
/// <remarks>Full RCON name: <c>weather.cloud_size</c></remarks>
public sealed class WeatherCloudSizeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.cloud_size";

    /// <summary>Reads the current value of <c>weather.cloud_size</c>.</summary>
    public static WeatherCloudSizeCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherCloudSizeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.cloud_size</c> to <paramref name="value"/>.</summary>
    public static WeatherCloudSizeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherCloudSizeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
