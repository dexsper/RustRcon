using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Kills all player boats that have more deployed entities than the given threshold; used for server cleanup</summary>
/// <remarks>Full RCON name: <c>playerboat.kill_all_above_deployable_count</c></remarks>
public sealed class PlayerboatKillAllAboveDeployableCountCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.kill_all_above_deployable_count";

    /// <summary>Creates a new <see cref="PlayerboatKillAllAboveDeployableCountCommand"/> command.</summary>
    public static PlayerboatKillAllAboveDeployableCountCommand Create()
    {
        var cmd = CreatePackage<PlayerboatKillAllAboveDeployableCountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
