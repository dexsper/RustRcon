using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Verbosity level for stability system logging; 0 = silent, higher values print more detail about stability calculations and propagation</summary>
/// <remarks>Full RCON name: <c>stability.verbose</c></remarks>
public sealed class StabilityVerboseCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "stability.verbose";

    /// <summary>Reads the current value of <c>stability.verbose</c>.</summary>
    public static StabilityVerboseCommand CreateGet()
    {
        var cmd = CreatePackage<StabilityVerboseCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>stability.verbose</c> to <paramref name="value"/>.</summary>
    public static StabilityVerboseCommand CreateSet(int value)
    {
        var cmd = CreatePackage<StabilityVerboseCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
