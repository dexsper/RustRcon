using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Exclusion radius in metres around each island used when finding valid spawn positions to prevent overlap</summary>
/// <remarks>Full RCON name: <c>deepsea.island_radius</c></remarks>
public sealed class DeepseaIslandRadiusCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.island_radius";

    /// <summary>Reads the current value of <c>deepsea.island_radius</c>.</summary>
    public static DeepseaIslandRadiusCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaIslandRadiusCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.island_radius</c> to <paramref name="value"/>.</summary>
    public static DeepseaIslandRadiusCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DeepseaIslandRadiusCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
