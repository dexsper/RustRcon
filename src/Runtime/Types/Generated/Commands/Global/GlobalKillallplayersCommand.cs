using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Deals lethal damage to every non-NPC player currently connected to the server; reports the number of players killed</summary>
/// <remarks>Full RCON name: <c>global.killallplayers</c></remarks>
public sealed class GlobalKillallplayersCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.killallplayers";

    /// <summary>Creates a new <see cref="GlobalKillallplayersCommand"/> command.</summary>
    public static GlobalKillallplayersCommand Create()
    {
        var cmd = CreatePackage<GlobalKillallplayersCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
