using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Whether to run local avoidance for chickens, disabling might get a slight performance improvement but chickens will clip</summary>
/// <remarks>Full RCON name: <c>server.farmchickenlocalavoidance</c></remarks>
public sealed class ServerFarmchickenlocalavoidanceCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.farmchickenlocalavoidance";

    /// <summary>Reads the current value of <c>server.farmchickenlocalavoidance</c>.</summary>
    public static ServerFarmchickenlocalavoidanceCommand CreateGet()
    {
        var cmd = CreatePackage<ServerFarmchickenlocalavoidanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.farmchickenlocalavoidance</c> to <paramref name="value"/>.</summary>
    public static ServerFarmchickenlocalavoidanceCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerFarmchickenlocalavoidanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
