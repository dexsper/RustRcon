using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>ioentity.framebudgetkineticms</c>.</summary>
/// <remarks>Full RCON name: <c>ioentity.framebudgetkineticms</c></remarks>
public sealed class IoentityFramebudgetkineticmsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ioentity.framebudgetkineticms";

    /// <summary>Reads the current value of <c>ioentity.framebudgetkineticms</c>.</summary>
    public static IoentityFramebudgetkineticmsCommand CreateGet()
    {
        var cmd = CreatePackage<IoentityFramebudgetkineticmsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ioentity.framebudgetkineticms</c> to <paramref name="value"/>.</summary>
    public static IoentityFramebudgetkineticmsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<IoentityFramebudgetkineticmsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
