using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>upgrade_radius 'grade' 'radius'</summary>
/// <remarks>Full RCON name: <c>global.upgrade_radius</c></remarks>
public sealed class GlobalUpgradeRadiusCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.upgrade_radius";

    /// <summary>Creates a new <see cref="GlobalUpgradeRadiusCommand"/> command.</summary>
    public static GlobalUpgradeRadiusCommand Create()
    {
        var cmd = CreatePackage<GlobalUpgradeRadiusCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
