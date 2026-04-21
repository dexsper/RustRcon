using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Initiates the deep sea opening sequence, activating portals and making the zone accessible to players; fails if already open or if an open/close is in progress</summary>
/// <remarks>Full RCON name: <c>deepsea.open</c></remarks>
public sealed class DeepseaOpenCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.open";

    /// <summary>Creates a new <see cref="DeepseaOpenCommand"/> command.</summary>
    public static DeepseaOpenCommand Create()
    {
        var cmd = CreatePackage<DeepseaOpenCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
