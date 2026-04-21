using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.noclip_protection</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.noclip_protection</c></remarks>
public sealed class AntihackNoclipProtectionCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.noclip_protection";

    /// <summary>Reads the current value of <c>antihack.noclip_protection</c>.</summary>
    public static AntihackNoclipProtectionCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackNoclipProtectionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.noclip_protection</c> to <paramref name="value"/>.</summary>
    public static AntihackNoclipProtectionCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AntihackNoclipProtectionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
