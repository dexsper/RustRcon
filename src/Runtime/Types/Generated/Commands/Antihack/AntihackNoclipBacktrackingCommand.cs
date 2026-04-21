using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.noclip_backtracking</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.noclip_backtracking</c></remarks>
public sealed class AntihackNoclipBacktrackingCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.noclip_backtracking";

    /// <summary>Reads the current value of <c>antihack.noclip_backtracking</c>.</summary>
    public static AntihackNoclipBacktrackingCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackNoclipBacktrackingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.noclip_backtracking</c> to <paramref name="value"/>.</summary>
    public static AntihackNoclipBacktrackingCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackNoclipBacktrackingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
