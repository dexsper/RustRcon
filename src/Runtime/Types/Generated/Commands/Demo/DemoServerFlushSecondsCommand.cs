using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) How often in seconds the server demo recording is flushed to disk (clamped 60-1800); more frequent flushes reduce data loss on crash</summary>
/// <remarks>Full RCON name: <c>demo.server_flush_seconds</c></remarks>
public sealed class DemoServerFlushSecondsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "demo.server_flush_seconds";

    /// <summary>Reads the current value of <c>demo.server_flush_seconds</c>.</summary>
    public static DemoServerFlushSecondsCommand CreateGet()
    {
        var cmd = CreatePackage<DemoServerFlushSecondsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>demo.server_flush_seconds</c> to <paramref name="value"/>.</summary>
    public static DemoServerFlushSecondsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<DemoServerFlushSecondsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
