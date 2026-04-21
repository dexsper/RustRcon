using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Adds skip queue permissions to a SteamID</summary>
/// <remarks>Full RCON name: <c>global.skipqueueid</c></remarks>
public sealed class GlobalSkipqueueidCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.skipqueueid";

    /// <summary>Creates a new <see cref="GlobalSkipqueueidCommand"/> command.</summary>
    public static GlobalSkipqueueidCommand Create(SteamId steamId, string arg1, string string2)
    {
        var cmd = CreatePackage<GlobalSkipqueueidCommand>();
        cmd.Content = $"{CommandFullName} {steamId} {arg1} {string2}";
        return cmd;
    }
}
