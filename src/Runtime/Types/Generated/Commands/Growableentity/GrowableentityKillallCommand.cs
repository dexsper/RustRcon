using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Server admin: kills all growable entities within 6m of the calling player, removing them from the planter</summary>
/// <remarks>Full RCON name: <c>growableentity.killall</c></remarks>
public sealed class GrowableentityKillallCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "growableentity.killall";

    /// <summary>Creates a new <see cref="GrowableentityKillallCommand"/> command.</summary>
    public static GrowableentityKillallCommand Create()
    {
        var cmd = CreatePackage<GrowableentityKillallCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
