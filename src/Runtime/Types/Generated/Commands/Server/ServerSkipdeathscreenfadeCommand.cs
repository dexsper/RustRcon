using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Skip death screen fade</summary>
/// <remarks>Full RCON name: <c>server.skipdeathscreenfade</c></remarks>
public sealed class ServerSkipdeathscreenfadeCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.skipdeathscreenfade";

    /// <summary>Reads the current value of <c>server.skipdeathscreenfade</c>.</summary>
    public static ServerSkipdeathscreenfadeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerSkipdeathscreenfadeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.skipdeathscreenfade</c> to <paramref name="value"/>.</summary>
    public static ServerSkipdeathscreenfadeCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerSkipdeathscreenfadeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
