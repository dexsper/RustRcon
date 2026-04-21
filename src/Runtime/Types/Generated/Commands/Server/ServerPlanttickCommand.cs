using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>server.planttick</c>.</summary>
/// <remarks>Full RCON name: <c>server.planttick</c></remarks>
public sealed class ServerPlanttickCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.planttick";

    /// <summary>Reads the current value of <c>server.planttick</c>.</summary>
    public static ServerPlanttickCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPlanttickCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.planttick</c> to <paramref name="value"/>.</summary>
    public static ServerPlanttickCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerPlanttickCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
