using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) IP address the server listens on for incoming connections; leave empty to bind to all available network interfaces</summary>
/// <remarks>Full RCON name: <c>app.listenip</c></remarks>
public sealed class AppListenipCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "app.listenip";

    /// <summary>Reads the current value of <c>app.listenip</c>.</summary>
    public static AppListenipCommand CreateGet()
    {
        var cmd = CreatePackage<AppListenipCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>app.listenip</c> to <paramref name="value"/>.</summary>
    public static AppListenipCommand CreateSet(string value)
    {
        var cmd = CreatePackage<AppListenipCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
