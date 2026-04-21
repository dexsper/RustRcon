using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>vendingmachine.max_processed</c>.</summary>
/// <remarks>Full RCON name: <c>vendingmachine.max_processed</c></remarks>
public sealed class VendingmachineMaxProcessedCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vendingmachine.max_processed";

    /// <summary>Reads the current value of <c>vendingmachine.max_processed</c>.</summary>
    public static VendingmachineMaxProcessedCommand CreateGet()
    {
        var cmd = CreatePackage<VendingmachineMaxProcessedCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>vendingmachine.max_processed</c> to <paramref name="value"/>.</summary>
    public static VendingmachineMaxProcessedCommand CreateSet(int value)
    {
        var cmd = CreatePackage<VendingmachineMaxProcessedCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
