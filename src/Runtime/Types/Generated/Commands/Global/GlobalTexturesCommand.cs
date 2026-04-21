using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints a list of all live Texture objects with their name and estimated runtime memory size</summary>
/// <remarks>Full RCON name: <c>global.textures</c></remarks>
public sealed class GlobalTexturesCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.textures";

    /// <summary>Creates a new <see cref="GlobalTexturesCommand"/> command.</summary>
    public static GlobalTexturesCommand Create()
    {
        var cmd = CreatePackage<GlobalTexturesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
