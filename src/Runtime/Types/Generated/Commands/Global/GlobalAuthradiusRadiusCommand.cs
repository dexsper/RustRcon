using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Finds all players within playerRadius of the caller, then authorises each of them to TCs within authRadius of themselves</summary>
/// <remarks>Full RCON name: <c>global.authradius_radius</c></remarks>
public sealed class GlobalAuthradiusRadiusCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.authradius_radius";

    /// <summary>Creates a new <see cref="GlobalAuthradiusRadiusCommand"/> command.</summary>
    public static GlobalAuthradiusRadiusCommand Create()
    {
        var cmd = CreatePackage<GlobalAuthradiusRadiusCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
