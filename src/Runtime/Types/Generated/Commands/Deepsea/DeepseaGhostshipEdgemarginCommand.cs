using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Minimum distance in metres ghost ships must be from the deep sea boundary edge when spawning</summary>
/// <remarks>Full RCON name: <c>deepsea.ghostship_edgemargin</c></remarks>
public sealed class DeepseaGhostshipEdgemarginCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.ghostship_edgemargin";

    /// <summary>Reads the current value of <c>deepsea.ghostship_edgemargin</c>.</summary>
    public static DeepseaGhostshipEdgemarginCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaGhostshipEdgemarginCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.ghostship_edgemargin</c> to <paramref name="value"/>.</summary>
    public static DeepseaGhostshipEdgemarginCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DeepseaGhostshipEdgemarginCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
