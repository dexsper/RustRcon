using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Removes skip queue permission from a SteamID</summary>
/// <remarks>Full RCON name: <c>global.removeskipqueue</c></remarks>
public sealed class GlobalRemoveskipqueueCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.removeskipqueue";

    /// <summary>Creates a new <see cref="GlobalRemoveskipqueueCommand"/> command.</summary>
    public static GlobalRemoveskipqueueCommand Create(SteamId steamId)
    {
        var cmd = CreatePackage<GlobalRemoveskipqueueCommand>();
        cmd.Content = $"{CommandFullName} {steamId}";
        return cmd;
    }
}
