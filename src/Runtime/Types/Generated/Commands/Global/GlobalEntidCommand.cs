using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Runs an admin command (kill, lock, unlock, etc.) on a specific entity by network ID; blocks operation on players and point entities</summary>
/// <remarks>Full RCON name: <c>global.entid</c></remarks>
public sealed class GlobalEntidCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.entid";

    /// <summary>Creates a new <see cref="GlobalEntidCommand"/> command.</summary>
    public static GlobalEntidCommand Create()
    {
        var cmd = CreatePackage<GlobalEntidCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
