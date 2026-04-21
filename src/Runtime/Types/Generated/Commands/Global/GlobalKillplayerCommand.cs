using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Deals 1000 damage to the specified player (by name/SteamID/bot) killing them immediately; useful for testing death logic without console kill commands</summary>
/// <remarks>Full RCON name: <c>global.killplayer</c></remarks>
public sealed class GlobalKillplayerCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.killplayer";

    /// <summary>Creates a new <see cref="GlobalKillplayerCommand"/> command.</summary>
    public static GlobalKillplayerCommand Create(string args)
    {
        var cmd = CreatePackage<GlobalKillplayerCommand>();
        cmd.Content = $"{CommandFullName} {args}";
        return cmd;
    }
}
