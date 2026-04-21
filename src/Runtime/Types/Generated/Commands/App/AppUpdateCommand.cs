using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Disables updating entirely - emergency use only</summary>
/// <remarks>Full RCON name: <c>app.update</c></remarks>
public sealed class AppUpdateCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "app.update";

    /// <summary>Reads the current value of <c>app.update</c>.</summary>
    public static AppUpdateCommand CreateGet()
    {
        var cmd = CreatePackage<AppUpdateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>app.update</c> to <paramref name="value"/>.</summary>
    public static AppUpdateCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AppUpdateCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
