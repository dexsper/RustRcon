using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Max number of queued messages - set to 0 to disable message processing</summary>
/// <remarks>Full RCON name: <c>app.queuelimit</c></remarks>
public sealed class AppQueuelimitCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "app.queuelimit";

    /// <summary>Reads the current value of <c>app.queuelimit</c>.</summary>
    public static AppQueuelimitCommand CreateGet()
    {
        var cmd = CreatePackage<AppQueuelimitCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>app.queuelimit</c> to <paramref name="value"/>.</summary>
    public static AppQueuelimitCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AppQueuelimitCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
