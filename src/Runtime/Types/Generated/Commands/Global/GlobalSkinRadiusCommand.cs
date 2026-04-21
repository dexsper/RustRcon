using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>skin_radius 'skin' 'radius'</summary>
/// <remarks>Full RCON name: <c>global.skin_radius</c></remarks>
public sealed class GlobalSkinRadiusCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.skin_radius";

    /// <summary>Creates a new <see cref="GlobalSkinRadiusCommand"/> command.</summary>
    public static GlobalSkinRadiusCommand Create()
    {
        var cmd = CreatePackage<GlobalSkinRadiusCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
