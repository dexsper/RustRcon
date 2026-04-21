using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints the current deep sea status including open/busy state, time to next opening, time to wipe, radiation amount, portal direction, entrance transform, and all active portal positions</summary>
/// <remarks>Full RCON name: <c>deepsea.status</c></remarks>
public sealed class DeepseaStatusCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.status";

    /// <summary>Creates a new <see cref="DeepseaStatusCommand"/> command.</summary>
    public static DeepseaStatusCommand Create()
    {
        var cmd = CreatePackage<DeepseaStatusCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
