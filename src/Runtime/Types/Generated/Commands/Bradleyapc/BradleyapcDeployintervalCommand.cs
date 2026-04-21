using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>bradleyapc.deployinterval</c>.</summary>
/// <remarks>Full RCON name: <c>bradleyapc.deployinterval</c></remarks>
public sealed class BradleyapcDeployintervalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bradleyapc.deployinterval";

    /// <summary>Reads the current value of <c>bradleyapc.deployinterval</c>.</summary>
    public static BradleyapcDeployintervalCommand CreateGet()
    {
        var cmd = CreatePackage<BradleyapcDeployintervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>bradleyapc.deployinterval</c> to <paramref name="value"/>.</summary>
    public static BradleyapcDeployintervalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BradleyapcDeployintervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
