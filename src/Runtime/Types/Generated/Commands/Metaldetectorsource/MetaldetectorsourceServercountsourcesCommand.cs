using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>metaldetectorsource.servercountsources</c>.</summary>
/// <remarks>Full RCON name: <c>metaldetectorsource.servercountsources</c></remarks>
public sealed class MetaldetectorsourceServercountsourcesCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "metaldetectorsource.servercountsources";

    /// <summary>Creates a new <see cref="MetaldetectorsourceServercountsourcesCommand"/> command.</summary>
    public static MetaldetectorsourceServercountsourcesCommand Create()
    {
        var cmd = CreatePackage<MetaldetectorsourceServercountsourcesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
