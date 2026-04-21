using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>npc.vendor_attack_heli_enabled</c>.</summary>
/// <remarks>Full RCON name: <c>npc.vendor_attack_heli_enabled</c></remarks>
public sealed class NpcVendorAttackHeliEnabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "npc.vendor_attack_heli_enabled";

    /// <summary>Reads the current value of <c>npc.vendor_attack_heli_enabled</c>.</summary>
    public static NpcVendorAttackHeliEnabledCommand CreateGet()
    {
        var cmd = CreatePackage<NpcVendorAttackHeliEnabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>npc.vendor_attack_heli_enabled</c> to <paramref name="value"/>.</summary>
    public static NpcVendorAttackHeliEnabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<NpcVendorAttackHeliEnabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
