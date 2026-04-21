using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints a detailed report of the current weather state including fog, rain, wind, cloud, and all climate parameter values; admin/developer only</summary>
/// <remarks>Full RCON name: <c>weather.report</c></remarks>
public sealed class WeatherReportCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.report";

    /// <summary>Creates a new <see cref="WeatherReportCommand"/> command.</summary>
    public static WeatherReportCommand Create()
    {
        var cmd = CreatePackage<WeatherReportCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
