using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Kills all bee swarms</summary>
/// <remarks>Full RCON name: <c>global.killbees</c></remarks>
public sealed class GlobalKillbeesCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.killbees";

    /// <summary>Creates a new <see cref="GlobalKillbeesCommand"/> command.</summary>
    public static GlobalKillbeesCommand Create()
    {
        var cmd = CreatePackage<GlobalKillbeesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
