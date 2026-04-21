using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Calls Resources.UnloadUnusedAssets() to unload assets no longer referenced by any object, freeing RAM and VRAM</summary>
/// <remarks>Full RCON name: <c>gc.unload</c></remarks>
public sealed class GcUnloadCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "gc.unload";

    /// <summary>Creates a new <see cref="GcUnloadCommand"/> command.</summary>
    public static GcUnloadCommand Create()
    {
        var cmd = CreatePackage<GcUnloadCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
