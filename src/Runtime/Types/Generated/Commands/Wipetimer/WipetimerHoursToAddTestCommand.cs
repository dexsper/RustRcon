using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of hours to add to the server's wipe timer during testing; registered as wipetimer.hours_to_add_test</summary>
/// <remarks>Full RCON name: <c>wipetimer.hours_to_add_test</c></remarks>
public sealed class WipetimerHoursToAddTestCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "wipetimer.hours_to_add_test";

    /// <summary>Reads the current value of <c>wipetimer.hours_to_add_test</c>.</summary>
    public static WipetimerHoursToAddTestCommand CreateGet()
    {
        var cmd = CreatePackage<WipetimerHoursToAddTestCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>wipetimer.hours_to_add_test</c> to <paramref name="value"/>.</summary>
    public static WipetimerHoursToAddTestCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WipetimerHoursToAddTestCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
