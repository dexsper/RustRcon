using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Generates a debug spawn map for a named population, simulating up to the given number of spawn attempts and reporting how many would succeed; used to diagnose spawn point coverage</summary>
/// <remarks>Full RCON name: <c>spawn.dump_map</c></remarks>
public sealed class SpawnDumpMapCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "spawn.dump_map";

    /// <summary>Creates a new <see cref="SpawnDumpMapCommand"/> command.</summary>
    public static SpawnDumpMapCommand Create()
    {
        var cmd = CreatePackage<SpawnDumpMapCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
