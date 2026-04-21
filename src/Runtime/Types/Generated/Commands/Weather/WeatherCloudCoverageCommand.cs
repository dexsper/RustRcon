using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.cloud_coverage</c>.</summary>
/// <remarks>Full RCON name: <c>weather.cloud_coverage</c></remarks>
public sealed class WeatherCloudCoverageCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.cloud_coverage";

    /// <summary>Reads the current value of <c>weather.cloud_coverage</c>.</summary>
    public static WeatherCloudCoverageCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherCloudCoverageCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.cloud_coverage</c> to <paramref name="value"/>.</summary>
    public static WeatherCloudCoverageCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherCloudCoverageCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
