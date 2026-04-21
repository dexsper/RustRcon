using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints the Facepunch application manifest in a formatted summary showing app name, version, and platform details</summary>
/// <remarks>Full RCON name: <c>manifest.printmanifest</c></remarks>
public sealed class ManifestPrintmanifestCommand : BaseCallCommand<object>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "manifest.printmanifest";

    /// <summary>Creates a new <see cref="ManifestPrintmanifestCommand"/> command.</summary>
    public static ManifestPrintmanifestCommand Create()
    {
        var cmd = CreatePackage<ManifestPrintmanifestCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
