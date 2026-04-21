using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.noclip_stepsize</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.noclip_stepsize</c></remarks>
public sealed class AntihackNoclipStepsizeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.noclip_stepsize";

    /// <summary>Reads the current value of <c>antihack.noclip_stepsize</c>.</summary>
    public static AntihackNoclipStepsizeCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackNoclipStepsizeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.noclip_stepsize</c> to <paramref name="value"/>.</summary>
    public static AntihackNoclipStepsizeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AntihackNoclipStepsizeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
