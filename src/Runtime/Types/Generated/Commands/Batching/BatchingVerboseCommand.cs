using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Verbosity level for static batching debug output; 0 = off, higher values print more detail about batch operations to the console</summary>
/// <remarks>Full RCON name: <c>batching.verbose</c></remarks>
public sealed class BatchingVerboseCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "batching.verbose";

    /// <summary>Reads the current value of <c>batching.verbose</c>.</summary>
    public static BatchingVerboseCommand CreateGet()
    {
        var cmd = CreatePackage<BatchingVerboseCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>batching.verbose</c> to <paramref name="value"/>.</summary>
    public static BatchingVerboseCommand CreateSet(int value)
    {
        var cmd = CreatePackage<BatchingVerboseCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
