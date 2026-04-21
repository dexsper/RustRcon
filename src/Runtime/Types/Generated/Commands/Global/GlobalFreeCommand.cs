using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Clears prefab pools and releases pooled objects; delegates to pool.clear_prefabs; admin/developer only</summary>
/// <remarks>Full RCON name: <c>global.free</c></remarks>
public sealed class GlobalFreeCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.free";

    /// <summary>Creates a new <see cref="GlobalFreeCommand"/> command.</summary>
    public static GlobalFreeCommand Create()
    {
        var cmd = CreatePackage<GlobalFreeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
