using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Loads a named volumetric cloud configuration and applies it to the climate override; admin/developer only; server replicates to clients</summary>
/// <remarks>Full RCON name: <c>weather.load_cloud_config</c></remarks>
public sealed class WeatherLoadCloudConfigCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.load_cloud_config";

    /// <summary>Creates a new <see cref="WeatherLoadCloudConfigCommand"/> command.</summary>
    public static WeatherLoadCloudConfigCommand Create()
    {
        var cmd = CreatePackage<WeatherLoadCloudConfigCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
