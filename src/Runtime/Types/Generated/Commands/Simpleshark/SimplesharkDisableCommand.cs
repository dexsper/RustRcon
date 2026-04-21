using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>simpleshark.disable</c>.</summary>
/// <remarks>Full RCON name: <c>simpleshark.disable</c></remarks>
public sealed class SimplesharkDisableCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "simpleshark.disable";

    /// <summary>Reads the current value of <c>simpleshark.disable</c>.</summary>
    public static SimplesharkDisableCommand CreateGet()
    {
        var cmd = CreatePackage<SimplesharkDisableCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>simpleshark.disable</c> to <paramref name="value"/>.</summary>
    public static SimplesharkDisableCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<SimplesharkDisableCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
