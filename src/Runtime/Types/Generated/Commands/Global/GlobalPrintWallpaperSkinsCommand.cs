using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Lists all wallpaper skins</summary>
/// <remarks>Full RCON name: <c>global.print_wallpaper_skins</c></remarks>
public sealed class GlobalPrintWallpaperSkinsCommand : BaseTextTableCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.print_wallpaper_skins";

    /// <summary>Creates a new <see cref="GlobalPrintWallpaperSkinsCommand"/> command.</summary>
    public static GlobalPrintWallpaperSkinsCommand Create()
    {
        var cmd = CreatePackage<GlobalPrintWallpaperSkinsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
