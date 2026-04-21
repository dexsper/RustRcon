using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum duration in seconds before a demo recording is automatically split into a new file; default is 3600 (1 hour)</summary>
/// <remarks>Full RCON name: <c>demo.splitseconds</c></remarks>
public sealed class DemoSplitsecondsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "demo.splitseconds";

    /// <summary>Reads the current value of <c>demo.splitseconds</c>.</summary>
    public static DemoSplitsecondsCommand CreateGet()
    {
        var cmd = CreatePackage<DemoSplitsecondsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>demo.splitseconds</c> to <paramref name="value"/>.</summary>
    public static DemoSplitsecondsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DemoSplitsecondsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
