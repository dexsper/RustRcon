using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>bradleyapc.spawnroadbradley</c>.</summary>
/// <remarks>Full RCON name: <c>bradleyapc.spawnroadbradley</c></remarks>
public sealed class BradleyapcSpawnroadbradleyCommand : BaseCallCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bradleyapc.spawnroadbradley";

    /// <summary>Creates a new <see cref="BradleyapcSpawnroadbradleyCommand"/> command.</summary>
    public static BradleyapcSpawnroadbradleyCommand Create()
    {
        var cmd = CreatePackage<BradleyapcSpawnroadbradleyCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
