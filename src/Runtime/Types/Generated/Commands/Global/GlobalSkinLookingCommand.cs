using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>&lt;skin&gt;</summary>
/// <remarks>Full RCON name: <c>global.skin_looking</c></remarks>
public sealed class GlobalSkinLookingCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.skin_looking";

    /// <summary>Creates a new <see cref="GlobalSkinLookingCommand"/> command.</summary>
    public static GlobalSkinLookingCommand Create()
    {
        var cmd = CreatePackage<GlobalSkinLookingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
