using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Minimum distance in metres required between floating city structures; prevents them overlapping when multiple are spawned</summary>
/// <remarks>Full RCON name: <c>deepsea.floatingcity_mindist</c></remarks>
public sealed class DeepseaFloatingcityMindistCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.floatingcity_mindist";

    /// <summary>Reads the current value of <c>deepsea.floatingcity_mindist</c>.</summary>
    public static DeepseaFloatingcityMindistCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaFloatingcityMindistCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.floatingcity_mindist</c> to <paramref name="value"/>.</summary>
    public static DeepseaFloatingcityMindistCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DeepseaFloatingcityMindistCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
