using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>bradleyapc.deployhealthrangemax</c>.</summary>
/// <remarks>Full RCON name: <c>bradleyapc.deployhealthrangemax</c></remarks>
public sealed class BradleyapcDeployhealthrangemaxCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bradleyapc.deployhealthrangemax";

    /// <summary>Reads the current value of <c>bradleyapc.deployhealthrangemax</c>.</summary>
    public static BradleyapcDeployhealthrangemaxCommand CreateGet()
    {
        var cmd = CreatePackage<BradleyapcDeployhealthrangemaxCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>bradleyapc.deployhealthrangemax</c> to <paramref name="value"/>.</summary>
    public static BradleyapcDeployhealthrangemaxCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BradleyapcDeployhealthrangemaxCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
