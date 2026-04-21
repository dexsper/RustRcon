using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, ItemManager uses object pooling for item instances to reduce GC allocations from frequent item creation and destruction</summary>
/// <remarks>Full RCON name: <c>itemmanager.enablepooling</c></remarks>
public sealed class ItemmanagerEnablepoolingCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "itemmanager.enablepooling";

    /// <summary>Reads the current value of <c>itemmanager.enablepooling</c>.</summary>
    public static ItemmanagerEnablepoolingCommand CreateGet()
    {
        var cmd = CreatePackage<ItemmanagerEnablepoolingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>itemmanager.enablepooling</c> to <paramref name="value"/>.</summary>
    public static ItemmanagerEnablepoolingCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ItemmanagerEnablepoolingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
