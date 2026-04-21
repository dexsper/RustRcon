using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>tutorialisland.debugislandpositions</c>.</summary>
/// <remarks>Full RCON name: <c>tutorialisland.debugislandpositions</c></remarks>
public sealed class TutorialislandDebugislandpositionsCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "tutorialisland.debugislandpositions";

    /// <summary>Creates a new <see cref="TutorialislandDebugislandpositionsCommand"/> command.</summary>
    public static TutorialislandDebugislandpositionsCommand Create()
    {
        var cmd = CreatePackage<TutorialislandDebugislandpositionsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
