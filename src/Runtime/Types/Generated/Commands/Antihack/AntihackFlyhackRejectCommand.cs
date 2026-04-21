using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.flyhack_reject</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.flyhack_reject</c></remarks>
public sealed class AntihackFlyhackRejectCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.flyhack_reject";

    /// <summary>Reads the current value of <c>antihack.flyhack_reject</c>.</summary>
    public static AntihackFlyhackRejectCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackFlyhackRejectCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.flyhack_reject</c> to <paramref name="value"/>.</summary>
    public static AntihackFlyhackRejectCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackFlyhackRejectCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
