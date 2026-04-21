using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Clears the volumetric cloud configuration override and resets cloud settings to the dynamic weather system; server replicates to clients</summary>
/// <remarks>Full RCON name: <c>weather.reset_cloud_config</c></remarks>
public sealed class WeatherResetCloudConfigCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.reset_cloud_config";

    /// <summary>Creates a new <see cref="WeatherResetCloudConfigCommand"/> command.</summary>
    public static WeatherResetCloudConfigCommand Create()
    {
        var cmd = CreatePackage<WeatherResetCloudConfigCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
