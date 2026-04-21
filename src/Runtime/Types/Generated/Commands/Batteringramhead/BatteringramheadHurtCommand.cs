using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Deals the specified amount of damage to the battering ram head entity nearest to the calling admin player; admin-only</summary>
/// <remarks>Full RCON name: <c>batteringramhead.hurt</c></remarks>
public sealed class BatteringramheadHurtCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "batteringramhead.hurt";

    /// <summary>Creates a new <see cref="BatteringramheadHurtCommand"/> command.</summary>
    public static BatteringramheadHurtCommand Create()
    {
        var cmd = CreatePackage<BatteringramheadHurtCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
