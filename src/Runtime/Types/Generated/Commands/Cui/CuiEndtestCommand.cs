using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>cui.endtest</c>.</summary>
/// <remarks>Full RCON name: <c>cui.endtest</c></remarks>
public sealed class CuiEndtestCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "cui.endtest";

    /// <summary>Creates a new <see cref="CuiEndtestCommand"/> command.</summary>
    public static CuiEndtestCommand Create()
    {
        var cmd = CreatePackage<CuiEndtestCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
