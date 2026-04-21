using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Wipe the backend customer stats data on all vending machines. Slow operation.</summary>
/// <remarks>Full RCON name: <c>vendingmachine.clearallvendingcustomerhistory</c></remarks>
public sealed class VendingmachineClearallvendingcustomerhistoryCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vendingmachine.clearallvendingcustomerhistory";

    /// <summary>Creates a new <see cref="VendingmachineClearallvendingcustomerhistoryCommand"/> command.</summary>
    public static VendingmachineClearallvendingcustomerhistoryCommand Create()
    {
        var cmd = CreatePackage<VendingmachineClearallvendingcustomerhistoryCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
