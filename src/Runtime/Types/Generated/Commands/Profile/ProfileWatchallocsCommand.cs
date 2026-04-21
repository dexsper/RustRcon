using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Params: [Name = 'Allocs'] [maxStackDepth = 16]. Starts tracking of allocs, dumping a [Name].json.gz record once conditions are met</summary>
/// <remarks>Full RCON name: <c>profile.watchallocs</c></remarks>
public sealed class ProfileWatchallocsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.watchallocs";

    /// <summary>Creates a new <see cref="ProfileWatchallocsCommand"/> command.</summary>
    public static ProfileWatchallocsCommand Create(string name, int arg1)
    {
        var cmd = CreatePackage<ProfileWatchallocsCommand>();
        cmd.Content = $"{CommandFullName} {name} {arg1}";
        return cmd;
    }
}
