using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>cui.cui_test</c>.</summary>
/// <remarks>Full RCON name: <c>cui.cui_test</c></remarks>
public sealed class CuiCuiTestCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "cui.cui_test";

    /// <summary>Creates a new <see cref="CuiCuiTestCommand"/> command.</summary>
    public static CuiCuiTestCommand Create()
    {
        var cmd = CreatePackage<CuiCuiTestCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
