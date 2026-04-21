using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>&lt;name/id&gt; &lt;radius&gt; | Use print_wallpaper_skins for a list | 0 -&gt; default, -1 -&gt; random</summary>
/// <remarks>Full RCON name: <c>global.add_wallpaper_radius</c></remarks>
public sealed class GlobalAddWallpaperRadiusCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.add_wallpaper_radius";

    /// <summary>Creates a new <see cref="GlobalAddWallpaperRadiusCommand"/> command.</summary>
    public static GlobalAddWallpaperRadiusCommand Create()
    {
        var cmd = CreatePackage<GlobalAddWallpaperRadiusCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
