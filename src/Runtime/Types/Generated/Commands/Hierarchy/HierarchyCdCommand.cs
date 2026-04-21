using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Changes the current hierarchy context to the named child GameObject, similar to the Unix cd command; allows drilling into nested scene objects</summary>
/// <remarks>Full RCON name: <c>hierarchy.cd</c></remarks>
public sealed class HierarchyCdCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "hierarchy.cd";

    /// <summary>Creates a new <see cref="HierarchyCdCommand"/> command.</summary>
    public static HierarchyCdCommand Create()
    {
        var cmd = CreatePackage<HierarchyCdCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
