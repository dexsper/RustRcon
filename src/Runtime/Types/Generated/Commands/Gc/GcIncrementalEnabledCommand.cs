using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Read-only: reports whether Unity incremental garbage collection is enabled for this runtime; cannot be changed at runtime</summary>
/// <remarks>Full RCON name: <c>gc.incremental_enabled</c></remarks>
public sealed class GcIncrementalEnabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "gc.incremental_enabled";

    /// <summary>Reads the current value of <c>gc.incremental_enabled</c>.</summary>
    public static GcIncrementalEnabledCommand CreateGet()
    {
        var cmd = CreatePackage<GcIncrementalEnabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>gc.incremental_enabled</c> to <paramref name="value"/>.</summary>
    public static GcIncrementalEnabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<GcIncrementalEnabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
