using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>bradleyapc.mountafternotfiredduration</c>.</summary>
/// <remarks>Full RCON name: <c>bradleyapc.mountafternotfiredduration</c></remarks>
public sealed class BradleyapcMountafternotfireddurationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bradleyapc.mountafternotfiredduration";

    /// <summary>Reads the current value of <c>bradleyapc.mountafternotfiredduration</c>.</summary>
    public static BradleyapcMountafternotfireddurationCommand CreateGet()
    {
        var cmd = CreatePackage<BradleyapcMountafternotfireddurationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>bradleyapc.mountafternotfiredduration</c> to <paramref name="value"/>.</summary>
    public static BradleyapcMountafternotfireddurationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BradleyapcMountafternotfireddurationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
