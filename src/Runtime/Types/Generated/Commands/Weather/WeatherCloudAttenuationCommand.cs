using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>weather.cloud_attenuation</c>.</summary>
/// <remarks>Full RCON name: <c>weather.cloud_attenuation</c></remarks>
public sealed class WeatherCloudAttenuationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.cloud_attenuation";

    /// <summary>Reads the current value of <c>weather.cloud_attenuation</c>.</summary>
    public static WeatherCloudAttenuationCommand CreateGet()
    {
        var cmd = CreatePackage<WeatherCloudAttenuationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>weather.cloud_attenuation</c> to <paramref name="value"/>.</summary>
    public static WeatherCloudAttenuationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WeatherCloudAttenuationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
