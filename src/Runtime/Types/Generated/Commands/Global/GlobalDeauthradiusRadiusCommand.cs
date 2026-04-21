using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Finds all players within playerRadius of the caller, then deauthorises each of them from TCs within authRadius of themselves</summary>
/// <remarks>Full RCON name: <c>global.deauthradius_radius</c></remarks>
public sealed class GlobalDeauthradiusRadiusCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.deauthradius_radius";

    /// <summary>Creates a new <see cref="GlobalDeauthradiusRadiusCommand"/> command.</summary>
    public static GlobalDeauthradiusRadiusCommand Create()
    {
        var cmd = CreatePackage<GlobalDeauthradiusRadiusCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
