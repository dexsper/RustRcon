using RustRcon.Types;
using RustRcon.Types.Commands.Base;
using RustRcon.Generated.Dtos;

namespace RustRcon.Generated.Commands;

/// <summary>Get a list of player's IDs</summary>
/// <remarks>Full RCON name: <c>global.playerlistids</c></remarks>
public sealed class GlobalPlayerlistidsCommand : BaseCallCommand<PlayerIDInfo[]>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.playerlistids";

    /// <summary>Creates a new <see cref="GlobalPlayerlistidsCommand"/> command.</summary>
    public static GlobalPlayerlistidsCommand Create()
    {
        var cmd = CreatePackage<GlobalPlayerlistidsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
