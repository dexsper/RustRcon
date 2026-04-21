using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Range to leave current target alone (should be higher than search)</summary>
/// <remarks>Full RCON name: <c>beeswarmai.breakrange</c></remarks>
public sealed class BeeswarmaiBreakrangeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "beeswarmai.breakrange";

    /// <summary>Reads the current value of <c>beeswarmai.breakrange</c>.</summary>
    public static BeeswarmaiBreakrangeCommand CreateGet()
    {
        var cmd = CreatePackage<BeeswarmaiBreakrangeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>beeswarmai.breakrange</c> to <paramref name="value"/>.</summary>
    public static BeeswarmaiBreakrangeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BeeswarmaiBreakrangeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
