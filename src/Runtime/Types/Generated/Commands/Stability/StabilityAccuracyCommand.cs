using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Floating-point tolerance used when comparing stability values during propagation; smaller values are more precise but can cause more recalculations</summary>
/// <remarks>Full RCON name: <c>stability.accuracy</c></remarks>
public sealed class StabilityAccuracyCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "stability.accuracy";

    /// <summary>Reads the current value of <c>stability.accuracy</c>.</summary>
    public static StabilityAccuracyCommand CreateGet()
    {
        var cmd = CreatePackage<StabilityAccuracyCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>stability.accuracy</c> to <paramref name="value"/>.</summary>
    public static StabilityAccuracyCommand CreateSet(float value)
    {
        var cmd = CreatePackage<StabilityAccuracyCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
