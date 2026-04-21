using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Server admin: forces all growable entities within 6m of the calling player to advance to their next growth stage instantly</summary>
/// <remarks>Full RCON name: <c>growableentity.growall</c></remarks>
public sealed class GrowableentityGrowallCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "growableentity.growall";

    /// <summary>Creates a new <see cref="GrowableentityGrowallCommand"/> command.</summary>
    public static GrowableentityGrowallCommand Create()
    {
        var cmd = CreatePackage<GrowableentityGrowallCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
