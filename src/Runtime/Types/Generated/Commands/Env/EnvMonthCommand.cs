using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Gets or sets the current in-game month (1-12); used for seasonal event triggers and calendar display</summary>
/// <remarks>Full RCON name: <c>env.month</c></remarks>
public sealed class EnvMonthCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "env.month";

    /// <summary>Reads the current value of <c>env.month</c>.</summary>
    public static EnvMonthCommand CreateGet()
    {
        var cmd = CreatePackage<EnvMonthCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>env.month</c> to <paramref name="value"/>.</summary>
    public static EnvMonthCommand CreateSet(int value)
    {
        var cmd = CreatePackage<EnvMonthCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
