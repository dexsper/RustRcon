using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Downloads a paste file stored on the server (legacy server-side storage) by name and sends its entity data to the requesting client for local storage</summary>
/// <remarks>Full RCON name: <c>copypaste.download_paste</c></remarks>
public sealed class CopypasteDownloadPasteCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "copypaste.download_paste";

    /// <summary>Creates a new <see cref="CopypasteDownloadPasteCommand"/> command.</summary>
    public static CopypasteDownloadPasteCommand Create(string arg0)
    {
        var cmd = CreatePackage<CopypasteDownloadPasteCommand>();
        cmd.Content = $"{CommandFullName} {arg0}";
        return cmd;
    }
}
