using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Counts and prints all entities that use synchronous movement updates grouped by prefab, helping identify expensive per-frame entity movers</summary>
/// <remarks>Full RCON name: <c>profile.countsyncmoveentities</c></remarks>
public sealed class ProfileCountsyncmoveentitiesCommand : BaseTextTableCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.countsyncmoveentities";

    /// <summary>Creates a new <see cref="ProfileCountsyncmoveentitiesCommand"/> command.</summary>
    public static ProfileCountsyncmoveentitiesCommand Create()
    {
        var cmd = CreatePackage<ProfileCountsyncmoveentitiesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
