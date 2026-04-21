using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Clears the saved audio recording from all cassette items currently on the server; returns count of cassettes cleared</summary>
/// <remarks>Full RCON name: <c>cassette.clearcassettes</c></remarks>
public sealed class CassetteClearcassettesCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "cassette.clearcassettes";

    /// <summary>Creates a new <see cref="CassetteClearcassettesCommand"/> command.</summary>
    public static CassetteClearcassettesCommand Create()
    {
        var cmd = CreatePackage<CassetteClearcassettesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
