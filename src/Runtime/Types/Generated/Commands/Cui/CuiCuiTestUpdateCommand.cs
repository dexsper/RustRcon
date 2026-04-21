using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>cui.cui_test_update</c>.</summary>
/// <remarks>Full RCON name: <c>cui.cui_test_update</c></remarks>
public sealed class CuiCuiTestUpdateCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "cui.cui_test_update";

    /// <summary>Creates a new <see cref="CuiCuiTestUpdateCommand"/> command.</summary>
    public static CuiCuiTestUpdateCommand Create()
    {
        var cmd = CreatePackage<CuiCuiTestUpdateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
