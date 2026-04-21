using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Creates the deep sea manager entity on the server, spawning all deep sea islands, ghost ships, and portals; kills any existing deep sea manager first if present</summary>
/// <remarks>Full RCON name: <c>deepsea.createdeepsea</c></remarks>
public sealed class DeepseaCreatedeepseaCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.createdeepsea";

    /// <summary>Creates a new <see cref="DeepseaCreatedeepseaCommand"/> command.</summary>
    public static DeepseaCreatedeepseaCommand Create()
    {
        var cmd = CreatePackage<DeepseaCreatedeepseaCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
