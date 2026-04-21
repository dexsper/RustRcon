using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>bradleyapc.deployattackdistancemax</c>.</summary>
/// <remarks>Full RCON name: <c>bradleyapc.deployattackdistancemax</c></remarks>
public sealed class BradleyapcDeployattackdistancemaxCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bradleyapc.deployattackdistancemax";

    /// <summary>Reads the current value of <c>bradleyapc.deployattackdistancemax</c>.</summary>
    public static BradleyapcDeployattackdistancemaxCommand CreateGet()
    {
        var cmd = CreatePackage<BradleyapcDeployattackdistancemaxCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>bradleyapc.deployattackdistancemax</c> to <paramref name="value"/>.</summary>
    public static BradleyapcDeployattackdistancemaxCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BradleyapcDeployattackdistancemaxCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
