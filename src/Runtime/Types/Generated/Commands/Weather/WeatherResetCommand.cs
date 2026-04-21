using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Resets all weather overrides and cloud configurations, restoring the dynamic weather system; admin/developer only; server replicates to clients</summary>
/// <remarks>Full RCON name: <c>weather.reset</c></remarks>
public sealed class WeatherResetCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.reset";

    /// <summary>Creates a new <see cref="WeatherResetCommand"/> command.</summary>
    public static WeatherResetCommand Create()
    {
        var cmd = CreatePackage<WeatherResetCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
