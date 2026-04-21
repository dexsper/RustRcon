using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, individually tracked entities (e.g. specific persistent NPCs) will respawn after a delay when destroyed</summary>
/// <remarks>Full RCON name: <c>spawn.respawn_individuals</c></remarks>
public sealed class SpawnRespawnIndividualsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "spawn.respawn_individuals";

    /// <summary>Reads the current value of <c>spawn.respawn_individuals</c>.</summary>
    public static SpawnRespawnIndividualsCommand CreateGet()
    {
        var cmd = CreatePackage<SpawnRespawnIndividualsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>spawn.respawn_individuals</c> to <paramref name="value"/>.</summary>
    public static SpawnRespawnIndividualsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<SpawnRespawnIndividualsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
