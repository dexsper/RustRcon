using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>waypointrace.startrace</c>.</summary>
/// <remarks>Full RCON name: <c>waypointrace.startrace</c></remarks>
public sealed class WaypointraceStartraceCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "waypointrace.startrace";

    /// <summary>Creates a new <see cref="WaypointraceStartraceCommand"/> command.</summary>
    public static WaypointraceStartraceCommand Create()
    {
        var cmd = CreatePackage<WaypointraceStartraceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
