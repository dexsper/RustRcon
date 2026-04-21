using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints the count of enabled versus disabled Collider components currently in the scene</summary>
/// <remarks>Full RCON name: <c>global.colliders</c></remarks>
public sealed class GlobalCollidersCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.colliders";

    /// <summary>Creates a new <see cref="GlobalCollidersCommand"/> command.</summary>
    public static GlobalCollidersCommand Create()
    {
        var cmd = CreatePackage<GlobalCollidersCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
