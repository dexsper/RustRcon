using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Deletes the named GameObject from the scene hierarchy; use with caution as this permanently removes the object</summary>
/// <remarks>Full RCON name: <c>hierarchy.del</c></remarks>
public sealed class HierarchyDelCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "hierarchy.del";

    /// <summary>Creates a new <see cref="HierarchyDelCommand"/> command.</summary>
    public static HierarchyDelCommand Create()
    {
        var cmd = CreatePackage<HierarchyDelCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
