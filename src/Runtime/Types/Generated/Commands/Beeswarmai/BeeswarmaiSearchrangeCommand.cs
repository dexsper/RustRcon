using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Range to find new targets</summary>
/// <remarks>Full RCON name: <c>beeswarmai.searchrange</c></remarks>
public sealed class BeeswarmaiSearchrangeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "beeswarmai.searchrange";

    /// <summary>Reads the current value of <c>beeswarmai.searchrange</c>.</summary>
    public static BeeswarmaiSearchrangeCommand CreateGet()
    {
        var cmd = CreatePackage<BeeswarmaiSearchrangeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>beeswarmai.searchrange</c> to <paramref name="value"/>.</summary>
    public static BeeswarmaiSearchrangeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BeeswarmaiSearchrangeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
