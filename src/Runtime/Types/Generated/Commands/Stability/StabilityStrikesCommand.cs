using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of stability propagation iterations performed per tick; higher values resolve complex multi-block stability chains faster at the cost of CPU time</summary>
/// <remarks>Full RCON name: <c>stability.strikes</c></remarks>
public sealed class StabilityStrikesCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "stability.strikes";

    /// <summary>Reads the current value of <c>stability.strikes</c>.</summary>
    public static StabilityStrikesCommand CreateGet()
    {
        var cmd = CreatePackage<StabilityStrikesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>stability.strikes</c> to <paramref name="value"/>.</summary>
    public static StabilityStrikesCommand CreateSet(int value)
    {
        var cmd = CreatePackage<StabilityStrikesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
