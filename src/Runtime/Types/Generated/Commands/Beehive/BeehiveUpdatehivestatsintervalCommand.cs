using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long before the Beehive will perform temperature and inside checks</summary>
/// <remarks>Full RCON name: <c>beehive.updatehivestatsinterval</c></remarks>
public sealed class BeehiveUpdatehivestatsintervalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "beehive.updatehivestatsinterval";

    /// <summary>Reads the current value of <c>beehive.updatehivestatsinterval</c>.</summary>
    public static BeehiveUpdatehivestatsintervalCommand CreateGet()
    {
        var cmd = CreatePackage<BeehiveUpdatehivestatsintervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>beehive.updatehivestatsinterval</c> to <paramref name="value"/>.</summary>
    public static BeehiveUpdatehivestatsintervalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BeehiveUpdatehivestatsintervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
