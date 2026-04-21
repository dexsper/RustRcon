using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.cloud_scattering</c>.</summary>
/// <remarks>Full RCON name: <c>weather.cloud_scattering</c></remarks>
public sealed class WeatherCloudScatteringCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.cloud_scattering";

    /// <summary>Reads the current value of <c>weather.cloud_scattering</c>.</summary>
    public static WeatherCloudScatteringCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherCloudScatteringCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.cloud_scattering</c> to <paramref name="value"/>.</summary>
    public static WeatherCloudScatteringCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherCloudScatteringCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
