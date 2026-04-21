using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Overrides the near (high-priority) network visibility radius in grid cells; -1 = use default</summary>
/// <remarks>Full RCON name: <c>net.visibilityradiusnearoverride</c></remarks>
public sealed class NetVisibilityradiusnearoverrideCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "net.visibilityradiusnearoverride";

    /// <summary>Reads the current value of <c>net.visibilityradiusnearoverride</c>.</summary>
    public static NetVisibilityradiusnearoverrideCommand CreateGet()
    {
        var cmd = CreatePackage<NetVisibilityradiusnearoverrideCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>net.visibilityradiusnearoverride</c> to <paramref name="value"/>.</summary>
    public static NetVisibilityradiusnearoverrideCommand CreateSet(int value)
    {
        var cmd = CreatePackage<NetVisibilityradiusnearoverrideCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
