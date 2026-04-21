using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>vendingmachine.max_returned</c>.</summary>
/// <remarks>Full RCON name: <c>vendingmachine.max_returned</c></remarks>
public sealed class VendingmachineMaxReturnedCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vendingmachine.max_returned";

    /// <summary>Reads the current value of <c>vendingmachine.max_returned</c>.</summary>
    public static VendingmachineMaxReturnedCommand CreateGet()
    {
        var cmd = CreatePackage<VendingmachineMaxReturnedCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>vendingmachine.max_returned</c> to <paramref name="value"/>.</summary>
    public static VendingmachineMaxReturnedCommand CreateSet(int value)
    {
        var cmd = CreatePackage<VendingmachineMaxReturnedCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
