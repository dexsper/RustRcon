using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>bradleyapc.deployondamagecheckinterval</c>.</summary>
/// <remarks>Full RCON name: <c>bradleyapc.deployondamagecheckinterval</c></remarks>
public sealed class BradleyapcDeployondamagecheckintervalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bradleyapc.deployondamagecheckinterval";

    /// <summary>Reads the current value of <c>bradleyapc.deployondamagecheckinterval</c>.</summary>
    public static BradleyapcDeployondamagecheckintervalCommand CreateGet()
    {
        var cmd = CreatePackage<BradleyapcDeployondamagecheckintervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>bradleyapc.deployondamagecheckinterval</c> to <paramref name="value"/>.</summary>
    public static BradleyapcDeployondamagecheckintervalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BradleyapcDeployondamagecheckintervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
