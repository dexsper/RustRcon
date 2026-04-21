using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>npc.vendor_rowboat_enabled</c>.</summary>
/// <remarks>Full RCON name: <c>npc.vendor_rowboat_enabled</c></remarks>
public sealed class NpcVendorRowboatEnabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "npc.vendor_rowboat_enabled";

    /// <summary>Reads the current value of <c>npc.vendor_rowboat_enabled</c>.</summary>
    public static NpcVendorRowboatEnabledCommand CreateGet()
    {
        var cmd = CreatePackage<NpcVendorRowboatEnabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>npc.vendor_rowboat_enabled</c> to <paramref name="value"/>.</summary>
    public static NpcVendorRowboatEnabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<NpcVendorRowboatEnabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
