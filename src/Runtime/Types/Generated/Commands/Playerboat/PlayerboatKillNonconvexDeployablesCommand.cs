using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Kills any entities deployed on boats with non-convex colliders. Not a fast command. Use sparingly when needed.</summary>
/// <remarks>Full RCON name: <c>playerboat.kill_nonconvex_deployables</c></remarks>
public sealed class PlayerboatKillNonconvexDeployablesCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.kill_nonconvex_deployables";

    /// <summary>Creates a new <see cref="PlayerboatKillNonconvexDeployablesCommand"/> command.</summary>
    public static PlayerboatKillNonconvexDeployablesCommand Create()
    {
        var cmd = CreatePackage<PlayerboatKillNonconvexDeployablesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
