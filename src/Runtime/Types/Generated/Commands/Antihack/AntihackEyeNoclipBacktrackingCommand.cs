using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.eye_noclip_backtracking</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.eye_noclip_backtracking</c></remarks>
public sealed class AntihackEyeNoclipBacktrackingCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.eye_noclip_backtracking";

    /// <summary>Reads the current value of <c>antihack.eye_noclip_backtracking</c>.</summary>
    public static AntihackEyeNoclipBacktrackingCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackEyeNoclipBacktrackingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.eye_noclip_backtracking</c> to <paramref name="value"/>.</summary>
    public static AntihackEyeNoclipBacktrackingCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackEyeNoclipBacktrackingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
