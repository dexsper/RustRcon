using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>npc.vendor_rhib_enabled</c>.</summary>
/// <remarks>Full RCON name: <c>npc.vendor_rhib_enabled</c></remarks>
public sealed class NpcVendorRhibEnabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "npc.vendor_rhib_enabled";

    /// <summary>Reads the current value of <c>npc.vendor_rhib_enabled</c>.</summary>
    public static NpcVendorRhibEnabledCommand CreateGet()
    {
        var cmd = CreatePackage<NpcVendorRhibEnabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>npc.vendor_rhib_enabled</c> to <paramref name="value"/>.</summary>
    public static NpcVendorRhibEnabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<NpcVendorRhibEnabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
