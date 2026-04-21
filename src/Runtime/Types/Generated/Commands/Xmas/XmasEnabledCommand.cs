using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Enables the Christmas event on the server, activating Christmas-themed loot spawns, trees, and holiday gift mechanics</summary>
/// <remarks>Full RCON name: <c>xmas.enabled</c></remarks>
public sealed class XmasEnabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "xmas.enabled";

    /// <summary>Reads the current value of <c>xmas.enabled</c>.</summary>
    public static XmasEnabledCommand CreateGet()
    {
        var cmd = CreatePackage<XmasEnabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>xmas.enabled</c> to <paramref name="value"/>.</summary>
    public static XmasEnabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<XmasEnabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
