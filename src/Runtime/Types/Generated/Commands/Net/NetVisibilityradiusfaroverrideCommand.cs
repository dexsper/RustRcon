using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Overrides the far network visibility radius in grid cells; -1 = use default; increase to send more distant entity updates to clients</summary>
/// <remarks>Full RCON name: <c>net.visibilityradiusfaroverride</c></remarks>
public sealed class NetVisibilityradiusfaroverrideCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "net.visibilityradiusfaroverride";

    /// <summary>Reads the current value of <c>net.visibilityradiusfaroverride</c>.</summary>
    public static NetVisibilityradiusfaroverrideCommand CreateGet()
    {
        var cmd = CreatePackage<NetVisibilityradiusfaroverrideCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>net.visibilityradiusfaroverride</c> to <paramref name="value"/>.</summary>
    public static NetVisibilityradiusfaroverrideCommand CreateSet(int value)
    {
        var cmd = CreatePackage<NetVisibilityradiusfaroverrideCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
