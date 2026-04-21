using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>growableentity.framebudgetms</c>.</summary>
/// <remarks>Full RCON name: <c>growableentity.framebudgetms</c></remarks>
public sealed class GrowableentityFramebudgetmsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "growableentity.framebudgetms";

    /// <summary>Reads the current value of <c>growableentity.framebudgetms</c>.</summary>
    public static GrowableentityFramebudgetmsCommand CreateGet()
    {
        var cmd = CreatePackage<GrowableentityFramebudgetmsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>growableentity.framebudgetms</c> to <paramref name="value"/>.</summary>
    public static GrowableentityFramebudgetmsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<GrowableentityFramebudgetmsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
