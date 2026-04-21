using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>npc.vendor_sub_solo_enabled</c>.</summary>
/// <remarks>Full RCON name: <c>npc.vendor_sub_solo_enabled</c></remarks>
public sealed class NpcVendorSubSoloEnabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "npc.vendor_sub_solo_enabled";

    /// <summary>Reads the current value of <c>npc.vendor_sub_solo_enabled</c>.</summary>
    public static NpcVendorSubSoloEnabledCommand CreateGet()
    {
        var cmd = CreatePackage<NpcVendorSubSoloEnabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>npc.vendor_sub_solo_enabled</c> to <paramref name="value"/>.</summary>
    public static NpcVendorSubSoloEnabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<NpcVendorSubSoloEnabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
