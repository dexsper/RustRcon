using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>junkpilewater.framebudgetms</c>.</summary>
/// <remarks>Full RCON name: <c>junkpilewater.framebudgetms</c></remarks>
public sealed class JunkpilewaterFramebudgetmsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "junkpilewater.framebudgetms";

    /// <summary>Reads the current value of <c>junkpilewater.framebudgetms</c>.</summary>
    public static JunkpilewaterFramebudgetmsCommand CreateGet()
    {
        var cmd = CreatePackage<JunkpilewaterFramebudgetmsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>junkpilewater.framebudgetms</c> to <paramref name="value"/>.</summary>
    public static JunkpilewaterFramebudgetmsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<JunkpilewaterFramebudgetmsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
