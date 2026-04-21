using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>ioentity.framebudgetgenericms</c>.</summary>
/// <remarks>Full RCON name: <c>ioentity.framebudgetgenericms</c></remarks>
public sealed class IoentityFramebudgetgenericmsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ioentity.framebudgetgenericms";

    /// <summary>Reads the current value of <c>ioentity.framebudgetgenericms</c>.</summary>
    public static IoentityFramebudgetgenericmsCommand CreateGet()
    {
        var cmd = CreatePackage<IoentityFramebudgetgenericmsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ioentity.framebudgetgenericms</c> to <paramref name="value"/>.</summary>
    public static IoentityFramebudgetgenericmsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<IoentityFramebudgetgenericmsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
