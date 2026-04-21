using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>ioentity.framebudgetindustrialms</c>.</summary>
/// <remarks>Full RCON name: <c>ioentity.framebudgetindustrialms</c></remarks>
public sealed class IoentityFramebudgetindustrialmsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ioentity.framebudgetindustrialms";

    /// <summary>Reads the current value of <c>ioentity.framebudgetindustrialms</c>.</summary>
    public static IoentityFramebudgetindustrialmsCommand CreateGet()
    {
        var cmd = CreatePackage<IoentityFramebudgetindustrialmsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ioentity.framebudgetindustrialms</c> to <paramref name="value"/>.</summary>
    public static IoentityFramebudgetindustrialmsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<IoentityFramebudgetindustrialmsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
