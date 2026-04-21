using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.flyhack_margin</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.flyhack_margin</c></remarks>
public sealed class AntihackFlyhackMarginCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.flyhack_margin";

    /// <summary>Reads the current value of <c>antihack.flyhack_margin</c>.</summary>
    public static AntihackFlyhackMarginCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackFlyhackMarginCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.flyhack_margin</c> to <paramref name="value"/>.</summary>
    public static AntihackFlyhackMarginCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackFlyhackMarginCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
