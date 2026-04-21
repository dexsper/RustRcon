using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>vinemountable.allowchaining</c>.</summary>
/// <remarks>Full RCON name: <c>vinemountable.allowchaining</c></remarks>
public sealed class VinemountableAllowchainingCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "vinemountable.allowchaining";

    /// <summary>Reads the current value of <c>vinemountable.allowchaining</c>.</summary>
    public static VinemountableAllowchainingCommand CreateGet()
    {
        var cmd = CreatePackage<VinemountableAllowchainingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>vinemountable.allowchaining</c> to <paramref name="value"/>.</summary>
    public static VinemountableAllowchainingCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<VinemountableAllowchainingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
