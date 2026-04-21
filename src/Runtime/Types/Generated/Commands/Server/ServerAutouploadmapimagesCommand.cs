using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Automatically upload an image of the map, used to show the map in the server browser</summary>
/// <remarks>Full RCON name: <c>server.autouploadmapimages</c></remarks>
public sealed class ServerAutouploadmapimagesCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.autouploadmapimages";

    /// <summary>Reads the current value of <c>server.autouploadmapimages</c>.</summary>
    public static ServerAutouploadmapimagesCommand CreateGet()
    {
        var cmd = CreatePackage<ServerAutouploadmapimagesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.autouploadmapimages</c> to <paramref name="value"/>.</summary>
    public static ServerAutouploadmapimagesCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerAutouploadmapimagesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
