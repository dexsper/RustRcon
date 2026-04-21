using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long before a Beehive will update</summary>
/// <remarks>Full RCON name: <c>beehive.updatehiveinterval</c></remarks>
public sealed class BeehiveUpdatehiveintervalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "beehive.updatehiveinterval";

    /// <summary>Reads the current value of <c>beehive.updatehiveinterval</c>.</summary>
    public static BeehiveUpdatehiveintervalCommand CreateGet()
    {
        var cmd = CreatePackage<BeehiveUpdatehiveintervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>beehive.updatehiveinterval</c> to <paramref name="value"/>.</summary>
    public static BeehiveUpdatehiveintervalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BeehiveUpdatehiveintervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
