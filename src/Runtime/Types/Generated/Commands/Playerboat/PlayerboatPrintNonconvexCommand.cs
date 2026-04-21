using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Prints a list of boats with non-convex collider deployables. Not a fast command. Use sparingly when needed.</summary>
/// <remarks>Full RCON name: <c>playerboat.print_nonconvex</c></remarks>
public sealed class PlayerboatPrintNonconvexCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.print_nonconvex";

    /// <summary>Creates a new <see cref="PlayerboatPrintNonconvexCommand"/> command.</summary>
    public static PlayerboatPrintNonconvexCommand Create()
    {
        var cmd = CreatePackage<PlayerboatPrintNonconvexCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
