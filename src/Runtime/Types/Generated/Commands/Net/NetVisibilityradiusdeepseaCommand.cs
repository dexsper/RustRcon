using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Network visibility radius in grid cells used in the deep-sea zone; kept smaller than overworld to limit underwater entity update overhead</summary>
/// <remarks>Full RCON name: <c>net.visibilityradiusdeepsea</c></remarks>
public sealed class NetVisibilityradiusdeepseaCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "net.visibilityradiusdeepsea";

    /// <summary>Reads the current value of <c>net.visibilityradiusdeepsea</c>.</summary>
    public static NetVisibilityradiusdeepseaCommand CreateGet()
    {
        var cmd = CreatePackage<NetVisibilityradiusdeepseaCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>net.visibilityradiusdeepsea</c> to <paramref name="value"/>.</summary>
    public static NetVisibilityradiusdeepseaCommand CreateSet(int value)
    {
        var cmd = CreatePackage<NetVisibilityradiusdeepseaCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
