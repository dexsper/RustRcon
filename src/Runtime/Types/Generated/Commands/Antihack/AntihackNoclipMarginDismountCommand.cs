using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.noclip_margin_dismount</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.noclip_margin_dismount</c></remarks>
public sealed class AntihackNoclipMarginDismountCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.noclip_margin_dismount";

    /// <summary>Reads the current value of <c>antihack.noclip_margin_dismount</c>.</summary>
    public static AntihackNoclipMarginDismountCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackNoclipMarginDismountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.noclip_margin_dismount</c> to <paramref name="value"/>.</summary>
    public static AntihackNoclipMarginDismountCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackNoclipMarginDismountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
