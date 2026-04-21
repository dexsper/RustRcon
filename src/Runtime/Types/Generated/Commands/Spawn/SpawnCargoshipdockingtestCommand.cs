using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Spawns a cargo ship and initiates the harbor docking test sequence at the specified docking path index; used to test cargo ship docking behaviour at harbors</summary>
/// <remarks>Full RCON name: <c>spawn.cargoshipdockingtest</c></remarks>
public sealed class SpawnCargoshipdockingtestCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "spawn.cargoshipdockingtest";

    /// <summary>Creates a new <see cref="SpawnCargoshipdockingtestCommand"/> command.</summary>
    public static SpawnCargoshipdockingtestCommand Create()
    {
        var cmd = CreatePackage<SpawnCargoshipdockingtestCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
