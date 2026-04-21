using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Forces a refresh of the Nexus island layout, re-querying the zone controller for current island assignments</summary>
/// <remarks>Full RCON name: <c>nexus.refreshislands</c></remarks>
public sealed class NexusRefreshislandsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "nexus.refreshislands";

    /// <summary>Creates a new <see cref="NexusRefreshislandsCommand"/> command.</summary>
    public static NexusRefreshislandsCommand Create()
    {
        var cmd = CreatePackage<NexusRefreshislandsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
