using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum milliseconds per frame the server spends advancing food spoil timers; lower values reduce frame time impact at the cost of less frequent spoil updates</summary>
/// <remarks>Full RCON name: <c>server.foodspoilingbudgetms</c></remarks>
public sealed class ServerFoodspoilingbudgetmsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.foodspoilingbudgetms";

    /// <summary>Reads the current value of <c>server.foodspoilingbudgetms</c>.</summary>
    public static ServerFoodspoilingbudgetmsCommand CreateGet()
    {
        var cmd = CreatePackage<ServerFoodspoilingbudgetmsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.foodspoilingbudgetms</c> to <paramref name="value"/>.</summary>
    public static ServerFoodspoilingbudgetmsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerFoodspoilingbudgetmsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
