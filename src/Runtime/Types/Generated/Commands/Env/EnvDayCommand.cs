using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Gets or sets the current in-game day of the month; used for calendar-driven events and date display</summary>
/// <remarks>Full RCON name: <c>env.day</c></remarks>
public sealed class EnvDayCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "env.day";

    /// <summary>Reads the current value of <c>env.day</c>.</summary>
    public static EnvDayCommand CreateGet()
    {
        var cmd = CreatePackage<EnvDayCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>env.day</c> to <paramref name="value"/>.</summary>
    public static EnvDayCommand CreateSet(int value)
    {
        var cmd = CreatePackage<EnvDayCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
