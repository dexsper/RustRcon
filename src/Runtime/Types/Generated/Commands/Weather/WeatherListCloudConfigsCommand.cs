using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Lists all available volumetric cloud configuration asset names registered in the Climate instance</summary>
/// <remarks>Full RCON name: <c>weather.list_cloud_configs</c></remarks>
public sealed class WeatherListCloudConfigsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.list_cloud_configs";

    /// <summary>Creates a new <see cref="WeatherListCloudConfigsCommand"/> command.</summary>
    public static WeatherListCloudConfigsCommand Create()
    {
        var cmd = CreatePackage<WeatherListCloudConfigsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
