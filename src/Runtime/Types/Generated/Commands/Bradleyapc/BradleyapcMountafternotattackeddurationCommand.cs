using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>bradleyapc.mountafternotattackedduration</c>.</summary>
/// <remarks>Full RCON name: <c>bradleyapc.mountafternotattackedduration</c></remarks>
public sealed class BradleyapcMountafternotattackeddurationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bradleyapc.mountafternotattackedduration";

    /// <summary>Reads the current value of <c>bradleyapc.mountafternotattackedduration</c>.</summary>
    public static BradleyapcMountafternotattackeddurationCommand CreateGet()
    {
        var cmd = CreatePackage<BradleyapcMountafternotattackeddurationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>bradleyapc.mountafternotattackedduration</c> to <paramref name="value"/>.</summary>
    public static BradleyapcMountafternotattackeddurationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BradleyapcMountafternotattackeddurationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
