using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Minimum distance in metres required between individual RHIB group spawn points</summary>
/// <remarks>Full RCON name: <c>deepsea.rhib_mindist</c></remarks>
public sealed class DeepseaRhibMindistCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.rhib_mindist";

    /// <summary>Reads the current value of <c>deepsea.rhib_mindist</c>.</summary>
    public static DeepseaRhibMindistCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaRhibMindistCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.rhib_mindist</c> to <paramref name="value"/>.</summary>
    public static DeepseaRhibMindistCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DeepseaRhibMindistCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
