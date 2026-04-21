using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Removes all spray paint entities created by a specific player, identified by Steam ID or name</summary>
/// <remarks>Full RCON name: <c>global.clearallspraysbyplayer</c></remarks>
public sealed class GlobalClearallspraysbyplayerCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.clearallspraysbyplayer";

    /// <summary>Creates a new <see cref="GlobalClearallspraysbyplayerCommand"/> command.</summary>
    public static GlobalClearallspraysbyplayerCommand Create(ulong uLong)
    {
        var cmd = CreatePackage<GlobalClearallspraysbyplayerCommand>();
        cmd.Content = $"{CommandFullName} {uLong}";
        return cmd;
    }
}
