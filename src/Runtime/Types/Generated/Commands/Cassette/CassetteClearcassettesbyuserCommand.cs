using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Clears saved audio from all cassettes created by the given Steam64 ID; returns count of cassettes cleared</summary>
/// <remarks>Full RCON name: <c>cassette.clearcassettesbyuser</c></remarks>
public sealed class CassetteClearcassettesbyuserCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "cassette.clearcassettesbyuser";

    /// <summary>Creates a new <see cref="CassetteClearcassettesbyuserCommand"/> command.</summary>
    public static CassetteClearcassettesbyuserCommand Create()
    {
        var cmd = CreatePackage<CassetteClearcassettesbyuserCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
