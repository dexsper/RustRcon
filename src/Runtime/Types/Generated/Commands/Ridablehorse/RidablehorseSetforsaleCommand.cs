using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Marks the horse directly in front of the calling admin player as for-sale, enabling the purchase interaction</summary>
/// <remarks>Full RCON name: <c>ridablehorse.setforsale</c></remarks>
public sealed class RidablehorseSetforsaleCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ridablehorse.setforsale";

    /// <summary>Creates a new <see cref="RidablehorseSetforsaleCommand"/> command.</summary>
    public static RidablehorseSetforsaleCommand Create()
    {
        var cmd = CreatePackage<RidablehorseSetforsaleCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
