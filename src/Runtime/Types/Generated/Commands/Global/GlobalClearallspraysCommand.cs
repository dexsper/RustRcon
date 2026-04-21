using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Removes all spray paint entities from the server world; useful for cleaning up excessive player spray art</summary>
/// <remarks>Full RCON name: <c>global.clearallsprays</c></remarks>
public sealed class GlobalClearallspraysCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.clearallsprays";

    /// <summary>Creates a new <see cref="GlobalClearallspraysCommand"/> command.</summary>
    public static GlobalClearallspraysCommand Create()
    {
        var cmd = CreatePackage<GlobalClearallspraysCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
