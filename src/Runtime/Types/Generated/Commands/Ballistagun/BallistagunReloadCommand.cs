using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Forces the ballista gun nearest to the calling admin player to reload immediately; admin-only</summary>
/// <remarks>Full RCON name: <c>ballistagun.reload</c></remarks>
public sealed class BallistagunReloadCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ballistagun.reload";

    /// <summary>Creates a new <see cref="BallistagunReloadCommand"/> command.</summary>
    public static BallistagunReloadCommand Create()
    {
        var cmd = CreatePackage<BallistagunReloadCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
