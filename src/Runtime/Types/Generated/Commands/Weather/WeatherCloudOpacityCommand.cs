using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.cloud_opacity</c>.</summary>
/// <remarks>Full RCON name: <c>weather.cloud_opacity</c></remarks>
public sealed class WeatherCloudOpacityCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.cloud_opacity";

    /// <summary>Reads the current value of <c>weather.cloud_opacity</c>.</summary>
    public static WeatherCloudOpacityCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherCloudOpacityCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.cloud_opacity</c> to <paramref name="value"/>.</summary>
    public static WeatherCloudOpacityCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherCloudOpacityCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
