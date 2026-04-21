using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Loads and applies a named weather preset to the climate system; admin/developer only; server replicates the change to all clients</summary>
/// <remarks>Full RCON name: <c>weather.load</c></remarks>
public sealed class WeatherLoadCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "weather.load";

    /// <summary>Creates a new <see cref="WeatherLoadCommand"/> command.</summary>
    public static WeatherLoadCommand Create()
    {
        var cmd = CreatePackage<WeatherLoadCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
