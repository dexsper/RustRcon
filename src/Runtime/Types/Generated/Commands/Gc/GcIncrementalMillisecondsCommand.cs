using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Time slice in milliseconds allocated to incremental GC per frame; lower values reduce GC stutter but spread collection over more frames</summary>
/// <remarks>Full RCON name: <c>gc.incremental_milliseconds</c></remarks>
public sealed class GcIncrementalMillisecondsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "gc.incremental_milliseconds";

    /// <summary>Reads the current value of <c>gc.incremental_milliseconds</c>.</summary>
    public static GcIncrementalMillisecondsCommand CreateGet()
    {
        var cmd = CreatePackage<GcIncrementalMillisecondsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>gc.incremental_milliseconds</c> to <paramref name="value"/>.</summary>
    public static GcIncrementalMillisecondsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<GcIncrementalMillisecondsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
