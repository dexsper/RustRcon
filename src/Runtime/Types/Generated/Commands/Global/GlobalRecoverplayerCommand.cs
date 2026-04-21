using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Recovers the specified player from the wounded state, standing them back up at minimum health</summary>
/// <remarks>Full RCON name: <c>global.recoverplayer</c></remarks>
public sealed class GlobalRecoverplayerCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.recoverplayer";

    /// <summary>Creates a new <see cref="GlobalRecoverplayerCommand"/> command.</summary>
    public static GlobalRecoverplayerCommand Create(string args)
    {
        var cmd = CreatePackage<GlobalRecoverplayerCommand>();
        cmd.Content = $"{CommandFullName} {args}";
        return cmd;
    }
}
