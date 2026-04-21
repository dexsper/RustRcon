using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.noclip_margin</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.noclip_margin</c></remarks>
public sealed class AntihackNoclipMarginCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.noclip_margin";

    /// <summary>Reads the current value of <c>antihack.noclip_margin</c>.</summary>
    public static AntihackNoclipMarginCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackNoclipMarginCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.noclip_margin</c> to <paramref name="value"/>.</summary>
    public static AntihackNoclipMarginCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackNoclipMarginCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
