using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Exclusion radius in metres around each ghost ship used during spawn placement</summary>
/// <remarks>Full RCON name: <c>deepsea.ghostship_radius</c></remarks>
public sealed class DeepseaGhostshipRadiusCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.ghostship_radius";

    /// <summary>Reads the current value of <c>deepsea.ghostship_radius</c>.</summary>
    public static DeepseaGhostshipRadiusCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaGhostshipRadiusCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.ghostship_radius</c> to <paramref name="value"/>.</summary>
    public static DeepseaGhostshipRadiusCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DeepseaGhostshipRadiusCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
