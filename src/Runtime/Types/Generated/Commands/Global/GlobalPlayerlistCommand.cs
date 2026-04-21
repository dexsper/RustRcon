using RustRcon.Types;
using RustRcon.Types.Commands.Base;
using RustRcon.Generated.Dtos;

namespace RustRcon.Generated.Commands;

/// <summary>Get a list of players</summary>
/// <remarks>Full RCON name: <c>global.playerlist</c></remarks>
public sealed class GlobalPlayerlistCommand : BaseCallCommand<PlayerInfo[]>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.playerlist";

    /// <summary>Creates a new <see cref="GlobalPlayerlistCommand"/> command.</summary>
    public static GlobalPlayerlistCommand Create()
    {
        var cmd = CreatePackage<GlobalPlayerlistCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
