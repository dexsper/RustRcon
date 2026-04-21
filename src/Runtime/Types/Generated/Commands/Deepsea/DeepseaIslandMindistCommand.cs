using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Minimum distance in metres required between individual island entities</summary>
/// <remarks>Full RCON name: <c>deepsea.island_mindist</c></remarks>
public sealed class DeepseaIslandMindistCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.island_mindist";

    /// <summary>Reads the current value of <c>deepsea.island_mindist</c>.</summary>
    public static DeepseaIslandMindistCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaIslandMindistCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.island_mindist</c> to <paramref name="value"/>.</summary>
    public static DeepseaIslandMindistCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DeepseaIslandMindistCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
