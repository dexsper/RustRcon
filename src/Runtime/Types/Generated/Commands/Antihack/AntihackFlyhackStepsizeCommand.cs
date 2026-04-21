using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.flyhack_stepsize</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.flyhack_stepsize</c></remarks>
public sealed class AntihackFlyhackStepsizeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.flyhack_stepsize";

    /// <summary>Reads the current value of <c>antihack.flyhack_stepsize</c>.</summary>
    public static AntihackFlyhackStepsizeCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackFlyhackStepsizeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.flyhack_stepsize</c> to <paramref name="value"/>.</summary>
    public static AntihackFlyhackStepsizeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackFlyhackStepsizeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
