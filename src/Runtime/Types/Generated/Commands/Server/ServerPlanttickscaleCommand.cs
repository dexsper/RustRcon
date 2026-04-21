using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Multiplier for plant growth tick speed; values above 1.0 make plants grow faster, values below 1.0 slow growth</summary>
/// <remarks>Full RCON name: <c>server.planttickscale</c></remarks>
public sealed class ServerPlanttickscaleCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.planttickscale";

    /// <summary>Reads the current value of <c>server.planttickscale</c>.</summary>
    public static ServerPlanttickscaleCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPlanttickscaleCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.planttickscale</c> to <paramref name="value"/>.</summary>
    public static ServerPlanttickscaleCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerPlanttickscaleCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
