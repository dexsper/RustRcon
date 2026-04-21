using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Exclusion radius in metres around each RHIB group during spawn placement</summary>
/// <remarks>Full RCON name: <c>deepsea.rhib_radius</c></remarks>
public sealed class DeepseaRhibRadiusCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.rhib_radius";

    /// <summary>Reads the current value of <c>deepsea.rhib_radius</c>.</summary>
    public static DeepseaRhibRadiusCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaRhibRadiusCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.rhib_radius</c> to <paramref name="value"/>.</summary>
    public static DeepseaRhibRadiusCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DeepseaRhibRadiusCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
