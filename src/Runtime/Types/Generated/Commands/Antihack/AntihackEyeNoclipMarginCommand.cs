using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.eye_noclip_margin</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.eye_noclip_margin</c></remarks>
public sealed class AntihackEyeNoclipMarginCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.eye_noclip_margin";

    /// <summary>Reads the current value of <c>antihack.eye_noclip_margin</c>.</summary>
    public static AntihackEyeNoclipMarginCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackEyeNoclipMarginCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.eye_noclip_margin</c> to <paramref name="value"/>.</summary>
    public static AntihackEyeNoclipMarginCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackEyeNoclipMarginCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
