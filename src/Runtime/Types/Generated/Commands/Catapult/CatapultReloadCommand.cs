using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Reload all catapults. 0: empty, 1: stone boulder, 2: fire bomb, 3: propane explosive, 4: bee bomb, 5: bot player</summary>
/// <remarks>Full RCON name: <c>catapult.reload</c></remarks>
public sealed class CatapultReloadCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "catapult.reload";

    /// <summary>Creates a new <see cref="CatapultReloadCommand"/> command.</summary>
    public static CatapultReloadCommand Create()
    {
        var cmd = CreatePackage<CatapultReloadCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
