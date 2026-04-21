using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>bradleyapc.deployhealthrangemin</c>.</summary>
/// <remarks>Full RCON name: <c>bradleyapc.deployhealthrangemin</c></remarks>
public sealed class BradleyapcDeployhealthrangeminCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bradleyapc.deployhealthrangemin";

    /// <summary>Reads the current value of <c>bradleyapc.deployhealthrangemin</c>.</summary>
    public static BradleyapcDeployhealthrangeminCommand CreateGet()
    {
        var cmd = CreatePackage<BradleyapcDeployhealthrangeminCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>bradleyapc.deployhealthrangemin</c> to <paramref name="value"/>.</summary>
    public static BradleyapcDeployhealthrangeminCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BradleyapcDeployhealthrangeminCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
