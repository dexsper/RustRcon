using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Controls whether the in-game admin UI is displayed to admins</summary>
/// <remarks>Full RCON name: <c>global.allowadminui</c></remarks>
public sealed class GlobalAllowadminuiCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.allowadminui";

    /// <summary>Reads the current value of <c>global.allowadminui</c>.</summary>
    public static GlobalAllowadminuiCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalAllowadminuiCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.allowadminui</c> to <paramref name="value"/>.</summary>
    public static GlobalAllowadminuiCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<GlobalAllowadminuiCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
