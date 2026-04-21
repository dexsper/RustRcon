using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of days to add to the server's wipe timer during testing; registered as wipetimer.days_to_add_test; 0 = no adjustment</summary>
/// <remarks>Full RCON name: <c>wipetimer.days_to_add_test</c></remarks>
public sealed class WipetimerDaysToAddTestCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "wipetimer.days_to_add_test";

    /// <summary>Reads the current value of <c>wipetimer.days_to_add_test</c>.</summary>
    public static WipetimerDaysToAddTestCommand CreateGet()
    {
        var cmd = CreatePackage<WipetimerDaysToAddTestCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>wipetimer.days_to_add_test</c> to <paramref name="value"/>.</summary>
    public static WipetimerDaysToAddTestCommand CreateSet(int value)
    {
        var cmd = CreatePackage<WipetimerDaysToAddTestCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
