using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints a sorted table of physics cells and how many colliders each contains; helps identify areas with excessive collider density causing physics slowdowns</summary>
/// <remarks>Full RCON name: <c>physics.print_colliders_per_cell</c></remarks>
public sealed class PhysicsPrintCollidersPerCellCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physics.print_colliders_per_cell";

    /// <summary>Creates a new <see cref="PhysicsPrintCollidersPerCellCommand"/> command.</summary>
    public static PhysicsPrintCollidersPerCellCommand Create()
    {
        var cmd = CreatePackage<PhysicsPrintCollidersPerCellCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
