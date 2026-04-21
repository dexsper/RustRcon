using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints the raw contents of the Facepunch manifest file as an unformatted string</summary>
/// <remarks>Full RCON name: <c>manifest.printmanifestraw</c></remarks>
public sealed class ManifestPrintmanifestrawCommand : BaseCallCommand<object>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "manifest.printmanifestraw";

    /// <summary>Creates a new <see cref="ManifestPrintmanifestrawCommand"/> command.</summary>
    public static ManifestPrintmanifestrawCommand Create()
    {
        var cmd = CreatePackage<ManifestPrintmanifestrawCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
