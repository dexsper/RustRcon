using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints a table of all monuments on the current map including type, display name, prefab path, and world position; admin/developer only</summary>
/// <remarks>Full RCON name: <c>world.monuments</c></remarks>
public sealed class WorldMonumentsCommand : BaseTextTableCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "world.monuments";

    /// <summary>Creates a new <see cref="WorldMonumentsCommand"/> command.</summary>
    public static WorldMonumentsCommand Create()
    {
        var cmd = CreatePackage<WorldMonumentsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
