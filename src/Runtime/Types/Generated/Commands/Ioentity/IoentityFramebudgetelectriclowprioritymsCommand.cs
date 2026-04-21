using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>ioentity.framebudgetelectriclowpriorityms</c>.</summary>
/// <remarks>Full RCON name: <c>ioentity.framebudgetelectriclowpriorityms</c></remarks>
public sealed class IoentityFramebudgetelectriclowprioritymsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ioentity.framebudgetelectriclowpriorityms";

    /// <summary>Reads the current value of <c>ioentity.framebudgetelectriclowpriorityms</c>.</summary>
    public static IoentityFramebudgetelectriclowprioritymsCommand CreateGet()
    {
        var cmd = CreatePackage<IoentityFramebudgetelectriclowprioritymsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ioentity.framebudgetelectriclowpriorityms</c> to <paramref name="value"/>.</summary>
    public static IoentityFramebudgetelectriclowprioritymsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<IoentityFramebudgetelectriclowprioritymsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
