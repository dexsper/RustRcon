using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints a JSON list of all system, Windows, and IANA timezone identifiers available on the server machine</summary>
/// <remarks>Full RCON name: <c>wipetimer.printtimezones</c></remarks>
public sealed class WipetimerPrinttimezonesCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "wipetimer.printtimezones";

    /// <summary>Creates a new <see cref="WipetimerPrinttimezonesCommand"/> command.</summary>
    public static WipetimerPrinttimezonesCommand Create()
    {
        var cmd = CreatePackage<WipetimerPrinttimezonesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
