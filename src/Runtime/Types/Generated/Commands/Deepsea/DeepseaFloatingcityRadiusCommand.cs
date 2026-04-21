using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Radius in metres used when finding valid spawn positions for floating cities; prevents them spawning too close to map edges</summary>
/// <remarks>Full RCON name: <c>deepsea.floatingcity_radius</c></remarks>
public sealed class DeepseaFloatingcityRadiusCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.floatingcity_radius";

    /// <summary>Reads the current value of <c>deepsea.floatingcity_radius</c>.</summary>
    public static DeepseaFloatingcityRadiusCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaFloatingcityRadiusCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.floatingcity_radius</c> to <paramref name="value"/>.</summary>
    public static DeepseaFloatingcityRadiusCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DeepseaFloatingcityRadiusCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
