using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.eye_noclip_cutoff</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.eye_noclip_cutoff</c></remarks>
public sealed class AntihackEyeNoclipCutoffCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.eye_noclip_cutoff";

    /// <summary>Reads the current value of <c>antihack.eye_noclip_cutoff</c>.</summary>
    public static AntihackEyeNoclipCutoffCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackEyeNoclipCutoffCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.eye_noclip_cutoff</c> to <paramref name="value"/>.</summary>
    public static AntihackEyeNoclipCutoffCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackEyeNoclipCutoffCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
