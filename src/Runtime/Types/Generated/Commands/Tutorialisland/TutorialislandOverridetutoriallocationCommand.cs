using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Will place the tutorial as close as possible to this pos, only for debugging</summary>
/// <remarks>Full RCON name: <c>tutorialisland.overridetutoriallocation</c></remarks>
public sealed class TutorialislandOverridetutoriallocationCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "tutorialisland.overridetutoriallocation";

    /// <summary>Reads the current value of <c>tutorialisland.overridetutoriallocation</c>.</summary>
    public static TutorialislandOverridetutoriallocationCommand CreateGet()
    {
        var cmd = CreatePackage<TutorialislandOverridetutoriallocationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>tutorialisland.overridetutoriallocation</c> to <paramref name="value"/>.</summary>
    public static TutorialislandOverridetutoriallocationCommand CreateSet(string value)
    {
        var cmd = CreatePackage<TutorialislandOverridetutoriallocationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
