using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) UDP port number the server listens on; default is 28015; must be open in firewall for players to connect</summary>
/// <remarks>Full RCON name: <c>app.port</c></remarks>
public sealed class AppPortCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "app.port";

    /// <summary>Reads the current value of <c>app.port</c>.</summary>
    public static AppPortCommand CreateGet()
    {
        var cmd = CreatePackage<AppPortCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>app.port</c> to <paramref name="value"/>.</summary>
    public static AppPortCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AppPortCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
