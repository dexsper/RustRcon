using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Minimum distance in metres islands must be from the deep sea boundary edge when spawning</summary>
/// <remarks>Full RCON name: <c>deepsea.island_edgemargin</c></remarks>
public sealed class DeepseaIslandEdgemarginCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.island_edgemargin";

    /// <summary>Reads the current value of <c>deepsea.island_edgemargin</c>.</summary>
    public static DeepseaIslandEdgemarginCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaIslandEdgemarginCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.island_edgemargin</c> to <paramref name="value"/>.</summary>
    public static DeepseaIslandEdgemarginCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DeepseaIslandEdgemarginCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
