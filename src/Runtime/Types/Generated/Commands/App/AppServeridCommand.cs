using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>app.serverid</c>.</summary>
/// <remarks>Full RCON name: <c>app.serverid</c></remarks>
public sealed class AppServeridCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "app.serverid";

    /// <summary>Reads the current value of <c>app.serverid</c>.</summary>
    public static AppServeridCommand CreateGet()
    {
        var cmd = CreatePackage<AppServeridCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>app.serverid</c> to <paramref name="value"/>.</summary>
    public static AppServeridCommand CreateSet(string value)
    {
        var cmd = CreatePackage<AppServeridCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
