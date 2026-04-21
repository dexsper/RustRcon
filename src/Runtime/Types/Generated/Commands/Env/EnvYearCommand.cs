using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Gets or sets the current in-game year; used for date display and long-running server event tracking</summary>
/// <remarks>Full RCON name: <c>env.year</c></remarks>
public sealed class EnvYearCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "env.year";

    /// <summary>Reads the current value of <c>env.year</c>.</summary>
    public static EnvYearCommand CreateGet()
    {
        var cmd = CreatePackage<EnvYearCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>env.year</c> to <paramref name="value"/>.</summary>
    public static EnvYearCommand CreateSet(int value)
    {
        var cmd = CreatePackage<EnvYearCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
