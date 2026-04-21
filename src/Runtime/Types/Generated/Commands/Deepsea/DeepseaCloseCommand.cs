using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Initiates the deep sea closing sequence (wipe), triggering the radiation end-phase and eventually destroying all deep sea entities; fails if already closed or busy</summary>
/// <remarks>Full RCON name: <c>deepsea.close</c></remarks>
public sealed class DeepseaCloseCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.close";

    /// <summary>Creates a new <see cref="DeepseaCloseCommand"/> command.</summary>
    public static DeepseaCloseCommand Create()
    {
        var cmd = CreatePackage<DeepseaCloseCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
