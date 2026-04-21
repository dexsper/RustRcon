using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>vendingmachine.max_history</c>.</summary>
/// <remarks>Full RCON name: <c>vendingmachine.max_history</c></remarks>
public sealed class VendingmachineMaxHistoryCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vendingmachine.max_history";

    /// <summary>Reads the current value of <c>vendingmachine.max_history</c>.</summary>
    public static VendingmachineMaxHistoryCommand CreateGet()
    {
        var cmd = CreatePackage<VendingmachineMaxHistoryCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>vendingmachine.max_history</c> to <paramref name="value"/>.</summary>
    public static VendingmachineMaxHistoryCommand CreateSet(int value)
    {
        var cmd = CreatePackage<VendingmachineMaxHistoryCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
