using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.speedhack_reject</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.speedhack_reject</c></remarks>
public sealed class AntihackSpeedhackRejectCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.speedhack_reject";

    /// <summary>Reads the current value of <c>antihack.speedhack_reject</c>.</summary>
    public static AntihackSpeedhackRejectCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackSpeedhackRejectCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.speedhack_reject</c> to <paramref name="value"/>.</summary>
    public static AntihackSpeedhackRejectCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackSpeedhackRejectCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
