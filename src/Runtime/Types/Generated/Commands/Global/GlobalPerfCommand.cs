using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Controls the on-screen performance overlay detail level; 0 = off, higher values add more metrics such as FPS, ping, entity count, and memory usage</summary>
/// <remarks>Full RCON name: <c>global.perf</c></remarks>
public sealed class GlobalPerfCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.perf";

    /// <summary>Reads the current value of <c>global.perf</c>.</summary>
    public static GlobalPerfCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalPerfCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.perf</c> to <paramref name="value"/>.</summary>
    public static GlobalPerfCommand CreateSet(int value)
    {
        var cmd = CreatePackage<GlobalPerfCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
