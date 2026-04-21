using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Whether items drop to the ground from a player's inventory when they die; disable to prevent item drops on death</summary>
/// <remarks>Full RCON name: <c>server.dropitems</c></remarks>
public sealed class ServerDropitemsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.dropitems";

    /// <summary>Reads the current value of <c>server.dropitems</c>.</summary>
    public static ServerDropitemsCommand CreateGet()
    {
        var cmd = CreatePackage<ServerDropitemsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.dropitems</c> to <paramref name="value"/>.</summary>
    public static ServerDropitemsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerDropitemsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
