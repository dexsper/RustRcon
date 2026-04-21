using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.noclip_reject</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.noclip_reject</c></remarks>
public sealed class AntihackNoclipRejectCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.noclip_reject";

    /// <summary>Reads the current value of <c>antihack.noclip_reject</c>.</summary>
    public static AntihackNoclipRejectCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackNoclipRejectCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.noclip_reject</c> to <paramref name="value"/>.</summary>
    public static AntihackNoclipRejectCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackNoclipRejectCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
