using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>fps.limit</c>.</summary>
/// <remarks>Full RCON name: <c>fps.limit</c></remarks>
public sealed class FpsLimitCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "fps.limit";

    /// <summary>Reads the current value of <c>fps.limit</c>.</summary>
    public static FpsLimitCommand CreateGet()
    {
        var cmd = CreatePackage<FpsLimitCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>fps.limit</c> to <paramref name="value"/>.</summary>
    public static FpsLimitCommand CreateSet(int value)
    {
        var cmd = CreatePackage<FpsLimitCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
