using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Setting this to true assigns a new random value to the world generation seed; useful for wipe scripts that want a fresh random map each time</summary>
/// <remarks>Full RCON name: <c>server.randomize_seed</c></remarks>
public sealed class ServerRandomizeSeedCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.randomize_seed";

    /// <summary>Reads the current value of <c>server.randomize_seed</c>.</summary>
    public static ServerRandomizeSeedCommand CreateGet()
    {
        var cmd = CreatePackage<ServerRandomizeSeedCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.randomize_seed</c> to <paramref name="value"/>.</summary>
    public static ServerRandomizeSeedCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerRandomizeSeedCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
