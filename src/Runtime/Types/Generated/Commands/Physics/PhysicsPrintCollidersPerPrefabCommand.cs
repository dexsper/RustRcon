using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints a sorted table of prefab names and their collider counts; identifies prefabs with unusually high collider counts for optimisation</summary>
/// <remarks>Full RCON name: <c>physics.print_colliders_per_prefab</c></remarks>
public sealed class PhysicsPrintCollidersPerPrefabCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physics.print_colliders_per_prefab";

    /// <summary>Creates a new <see cref="PhysicsPrintCollidersPerPrefabCommand"/> command.</summary>
    public static PhysicsPrintCollidersPerPrefabCommand Create(int cellId)
    {
        var cmd = CreatePackage<PhysicsPrintCollidersPerPrefabCommand>();
        cmd.Content = $"{CommandFullName} {cellId}";
        return cmd;
    }
}
