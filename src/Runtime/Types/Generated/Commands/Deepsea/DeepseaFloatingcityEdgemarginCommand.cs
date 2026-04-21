using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Minimum distance in metres floating cities must be from the deep sea boundary edge when spawning</summary>
/// <remarks>Full RCON name: <c>deepsea.floatingcity_edgemargin</c></remarks>
public sealed class DeepseaFloatingcityEdgemarginCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.floatingcity_edgemargin";

    /// <summary>Reads the current value of <c>deepsea.floatingcity_edgemargin</c>.</summary>
    public static DeepseaFloatingcityEdgemarginCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaFloatingcityEdgemarginCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.floatingcity_edgemargin</c> to <paramref name="value"/>.</summary>
    public static DeepseaFloatingcityEdgemarginCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DeepseaFloatingcityEdgemarginCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
