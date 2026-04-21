using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Print a list of all scientists that are off the navmesh. Optionally kill them off by passing true as the first argument.</summary>
/// <remarks>Full RCON name: <c>ai.printorkilloffnavscientists</c></remarks>
public sealed class AiPrintorkilloffnavscientistsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.printorkilloffnavscientists";

    /// <summary>Creates a new <see cref="AiPrintorkilloffnavscientistsCommand"/> command.</summary>
    public static AiPrintorkilloffnavscientistsCommand Create()
    {
        var cmd = CreatePackage<AiPrintorkilloffnavscientistsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
