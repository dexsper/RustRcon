using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Returns a JSON object containing the UGC info (CRCs, type, player history) for the entity with the given network ID</summary>
/// <remarks>Full RCON name: <c>global.getugcinfo</c></remarks>
public sealed class GlobalGetugcinfoCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.getugcinfo";

    /// <summary>Creates a new <see cref="GlobalGetugcinfoCommand"/> command.</summary>
    public static GlobalGetugcinfoCommand Create()
    {
        var cmd = CreatePackage<GlobalGetugcinfoCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
