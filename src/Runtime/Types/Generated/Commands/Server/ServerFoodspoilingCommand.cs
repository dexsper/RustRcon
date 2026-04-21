using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Whether to run the food spoiling system</summary>
/// <remarks>Full RCON name: <c>server.foodspoiling</c></remarks>
public sealed class ServerFoodspoilingCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.foodspoiling";

    /// <summary>Reads the current value of <c>server.foodspoiling</c>.</summary>
    public static ServerFoodspoilingCommand CreateGet()
    {
        var cmd = CreatePackage<ServerFoodspoilingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.foodspoiling</c> to <paramref name="value"/>.</summary>
    public static ServerFoodspoilingCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerFoodspoilingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
