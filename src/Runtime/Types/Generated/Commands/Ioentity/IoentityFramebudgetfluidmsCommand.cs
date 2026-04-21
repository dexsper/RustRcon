using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>ioentity.framebudgetfluidms</c>.</summary>
/// <remarks>Full RCON name: <c>ioentity.framebudgetfluidms</c></remarks>
public sealed class IoentityFramebudgetfluidmsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ioentity.framebudgetfluidms";

    /// <summary>Reads the current value of <c>ioentity.framebudgetfluidms</c>.</summary>
    public static IoentityFramebudgetfluidmsCommand CreateGet()
    {
        var cmd = CreatePackage<IoentityFramebudgetfluidmsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ioentity.framebudgetfluidms</c> to <paramref name="value"/>.</summary>
    public static IoentityFramebudgetfluidmsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<IoentityFramebudgetfluidmsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
