using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>bradleyapc.mountafternottargetsduration</c>.</summary>
/// <remarks>Full RCON name: <c>bradleyapc.mountafternottargetsduration</c></remarks>
public sealed class BradleyapcMountafternottargetsdurationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bradleyapc.mountafternottargetsduration";

    /// <summary>Reads the current value of <c>bradleyapc.mountafternottargetsduration</c>.</summary>
    public static BradleyapcMountafternottargetsdurationCommand CreateGet()
    {
        var cmd = CreatePackage<BradleyapcMountafternottargetsdurationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>bradleyapc.mountafternottargetsduration</c> to <paramref name="value"/>.</summary>
    public static BradleyapcMountafternottargetsdurationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BradleyapcMountafternottargetsdurationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
