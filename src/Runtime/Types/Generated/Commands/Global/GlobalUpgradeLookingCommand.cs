using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>&lt;grade&gt;</summary>
/// <remarks>Full RCON name: <c>global.upgrade_looking</c></remarks>
public sealed class GlobalUpgradeLookingCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.upgrade_looking";

    /// <summary>Creates a new <see cref="GlobalUpgradeLookingCommand"/> command.</summary>
    public static GlobalUpgradeLookingCommand Create()
    {
        var cmd = CreatePackage<GlobalUpgradeLookingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
