using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>slotmachine.forcepayoutindex</c>.</summary>
/// <remarks>Full RCON name: <c>slotmachine.forcepayoutindex</c></remarks>
public sealed class SlotmachineForcepayoutindexCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "slotmachine.forcepayoutindex";

    /// <summary>Reads the current value of <c>slotmachine.forcepayoutindex</c>.</summary>
    public static SlotmachineForcepayoutindexCommand CreateGet()
    {
        var cmd = CreatePackage<SlotmachineForcepayoutindexCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>slotmachine.forcepayoutindex</c> to <paramref name="value"/>.</summary>
    public static SlotmachineForcepayoutindexCommand CreateSet(int value)
    {
        var cmd = CreatePackage<SlotmachineForcepayoutindexCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
