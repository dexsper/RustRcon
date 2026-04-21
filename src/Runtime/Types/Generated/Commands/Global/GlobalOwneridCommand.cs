using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Adds the specified Steam64 ID as a server owner (auth level 2) with optional name and reason; requires the caller to also be auth level 2</summary>
/// <remarks>Full RCON name: <c>global.ownerid</c></remarks>
public sealed class GlobalOwneridCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.ownerid";

    /// <summary>Creates a new <see cref="GlobalOwneridCommand"/> command.</summary>
    public static GlobalOwneridCommand Create(SteamId steamId, string arg1, string string2)
    {
        var cmd = CreatePackage<GlobalOwneridCommand>();
        cmd.Content = $"{CommandFullName} {steamId} {arg1} {string2}";
        return cmd;
    }
}
