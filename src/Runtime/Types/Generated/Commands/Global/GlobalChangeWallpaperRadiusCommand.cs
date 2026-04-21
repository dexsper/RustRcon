using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>&lt;name/id&gt; &lt;radius&gt; | Use print_wallpaper_skins for a list | 0 -&gt; default, -1 -&gt; random</summary>
/// <remarks>Full RCON name: <c>global.change_wallpaper_radius</c></remarks>
public sealed class GlobalChangeWallpaperRadiusCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.change_wallpaper_radius";

    /// <summary>Creates a new <see cref="GlobalChangeWallpaperRadiusCommand"/> command.</summary>
    public static GlobalChangeWallpaperRadiusCommand Create()
    {
        var cmd = CreatePackage<GlobalChangeWallpaperRadiusCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
