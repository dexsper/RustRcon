using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>ioentity.framebudgetelectrichighpriorityms</c>.</summary>
/// <remarks>Full RCON name: <c>ioentity.framebudgetelectrichighpriorityms</c></remarks>
public sealed class IoentityFramebudgetelectrichighprioritymsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ioentity.framebudgetelectrichighpriorityms";

    /// <summary>Reads the current value of <c>ioentity.framebudgetelectrichighpriorityms</c>.</summary>
    public static IoentityFramebudgetelectrichighprioritymsCommand CreateGet()
    {
        var cmd = CreatePackage<IoentityFramebudgetelectrichighprioritymsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ioentity.framebudgetelectrichighpriorityms</c> to <paramref name="value"/>.</summary>
    public static IoentityFramebudgetelectrichighprioritymsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<IoentityFramebudgetelectrichighprioritymsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
