using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Allows backpack equipping while not grounded</summary>
/// <remarks>Full RCON name: <c>server.canequipbackpacksinair</c></remarks>
public sealed class ServerCanequipbackpacksinairCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.canequipbackpacksinair";

    /// <summary>Reads the current value of <c>server.canequipbackpacksinair</c>.</summary>
    public static ServerCanequipbackpacksinairCommand CreateGet()
    {
        var cmd = CreatePackage<ServerCanequipbackpacksinairCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.canequipbackpacksinair</c> to <paramref name="value"/>.</summary>
    public static ServerCanequipbackpacksinairCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerCanequipbackpacksinairCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
