using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Enables sending push notifications</summary>
/// <remarks>Full RCON name: <c>app.notifications</c></remarks>
public sealed class AppNotificationsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "app.notifications";

    /// <summary>Reads the current value of <c>app.notifications</c>.</summary>
    public static AppNotificationsCommand CreateGet()
    {
        var cmd = CreatePackage<AppNotificationsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>app.notifications</c> to <paramref name="value"/>.</summary>
    public static AppNotificationsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AppNotificationsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
