using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Maximum distance to test to see if a structure is outside, higher values are slower but accurate for huge buildings</summary>
/// <remarks>Full RCON name: <c>decay.outside_test_range</c></remarks>
public sealed class DecayOutsideTestRangeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.outside_test_range";

    /// <summary>Reads the current value of <c>decay.outside_test_range</c>.</summary>
    public static DecayOutsideTestRangeCommand CreateGet()
    {
        var cmd = CreatePackage<DecayOutsideTestRangeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.outside_test_range</c> to <paramref name="value"/>.</summary>
    public static DecayOutsideTestRangeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayOutsideTestRangeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
