using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.cloud_coloring</c>.</summary>
/// <remarks>Full RCON name: <c>weather.cloud_coloring</c></remarks>
public sealed class WeatherCloudColoringCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.cloud_coloring";

    /// <summary>Reads the current value of <c>weather.cloud_coloring</c>.</summary>
    public static WeatherCloudColoringCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherCloudColoringCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.cloud_coloring</c> to <paramref name="value"/>.</summary>
    public static WeatherCloudColoringCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherCloudColoringCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
