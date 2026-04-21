using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When true, fall damage is calculated server-side for improved anti-cheat security; disabling may reduce server load but allows clients to manipulate fall damage</summary>
/// <remarks>Full RCON name: <c>server.playerserverfall</c></remarks>
public sealed class ServerPlayerserverfallCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.playerserverfall";

    /// <summary>Reads the current value of <c>server.playerserverfall</c>.</summary>
    public static ServerPlayerserverfallCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPlayerserverfallCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.playerserverfall</c> to <paramref name="value"/>.</summary>
    public static ServerPlayerserverfallCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerPlayerserverfallCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
