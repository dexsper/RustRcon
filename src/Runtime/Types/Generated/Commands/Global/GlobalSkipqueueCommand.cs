using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Moves the specified Steam64 ID to the front of the connection queue so they connect immediately on next join</summary>
/// <remarks>Full RCON name: <c>global.skipqueue</c></remarks>
public sealed class GlobalSkipqueueCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.skipqueue";

    /// <summary>Creates a new <see cref="GlobalSkipqueueCommand"/> command.</summary>
    public static GlobalSkipqueueCommand Create(SteamId steamId)
    {
        var cmd = CreatePackage<GlobalSkipqueueCommand>();
        cmd.Content = $"{CommandFullName} {steamId}";
        return cmd;
    }
}
