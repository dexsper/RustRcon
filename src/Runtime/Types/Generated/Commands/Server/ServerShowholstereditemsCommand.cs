using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, weapons and tools holstered on a player's back are visible on their character model to other players</summary>
/// <remarks>Full RCON name: <c>server.showholstereditems</c></remarks>
public sealed class ServerShowholstereditemsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.showholstereditems";

    /// <summary>Reads the current value of <c>server.showholstereditems</c>.</summary>
    public static ServerShowholstereditemsCommand CreateGet()
    {
        var cmd = CreatePackage<ServerShowholstereditemsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.showholstereditems</c> to <paramref name="value"/>.</summary>
    public static ServerShowholstereditemsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerShowholstereditemsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
