using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Forces an immediate recalculation of stability for all building blocks in the world; expensive on large bases</summary>
/// <remarks>Full RCON name: <c>stability.refresh_stability</c></remarks>
public sealed class StabilityRefreshStabilityCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "stability.refresh_stability";

    /// <summary>Creates a new <see cref="StabilityRefreshStabilityCommand"/> command.</summary>
    public static StabilityRefreshStabilityCommand Create()
    {
        var cmd = CreatePackage<StabilityRefreshStabilityCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
