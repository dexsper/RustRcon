using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Kills all player boats that have more building blocks than the given threshold; used for server cleanup</summary>
/// <remarks>Full RCON name: <c>playerboat.kill_all_above_block_count</c></remarks>
public sealed class PlayerboatKillAllAboveBlockCountCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.kill_all_above_block_count";

    /// <summary>Creates a new <see cref="PlayerboatKillAllAboveBlockCountCommand"/> command.</summary>
    public static PlayerboatKillAllAboveBlockCountCommand Create()
    {
        var cmd = CreatePackage<PlayerboatKillAllAboveBlockCountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
