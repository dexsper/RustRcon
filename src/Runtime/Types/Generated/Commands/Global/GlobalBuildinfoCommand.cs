using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Get information about this build</summary>
/// <remarks>Full RCON name: <c>global.buildinfo</c></remarks>
public sealed class GlobalBuildinfoCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.buildinfo";

    /// <summary>Creates a new <see cref="GlobalBuildinfoCommand"/> command.</summary>
    public static GlobalBuildinfoCommand Create()
    {
        var cmd = CreatePackage<GlobalBuildinfoCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
