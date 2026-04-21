using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Kills any IO entities deployed on boats. Not a fast command. Use sparingly when needed.</summary>
/// <remarks>Full RCON name: <c>playerboat.kill_io_deployables</c></remarks>
public sealed class PlayerboatKillIoDeployablesCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.kill_io_deployables";

    /// <summary>Creates a new <see cref="PlayerboatKillIoDeployablesCommand"/> command.</summary>
    public static PlayerboatKillIoDeployablesCommand Create()
    {
        var cmd = CreatePackage<PlayerboatKillIoDeployablesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
