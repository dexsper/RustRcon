using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Wipe the backend stats data on all vending machines. Slow operation.</summary>
/// <remarks>Full RCON name: <c>vendingmachine.clearallvendinghistory</c></remarks>
public sealed class VendingmachineClearallvendinghistoryCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vendingmachine.clearallvendinghistory";

    /// <summary>Creates a new <see cref="VendingmachineClearallvendinghistoryCommand"/> command.</summary>
    public static VendingmachineClearallvendinghistoryCommand Create()
    {
        var cmd = CreatePackage<VendingmachineClearallvendinghistoryCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
