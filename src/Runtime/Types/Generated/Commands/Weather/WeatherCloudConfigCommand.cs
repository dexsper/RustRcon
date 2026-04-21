using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.cloud_config</c>.</summary>
/// <remarks>Full RCON name: <c>weather.cloud_config</c></remarks>
public sealed class WeatherCloudConfigCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.cloud_config";

    /// <summary>Reads the current value of <c>weather.cloud_config</c>.</summary>
    public static WeatherCloudConfigCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherCloudConfigCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.cloud_config</c> to <paramref name="value"/>.</summary>
    public static WeatherCloudConfigCommand CreateSet(int value)
    {
        var cmd = CreatePackage<WeatherCloudConfigCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
