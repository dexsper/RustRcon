using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Minimum distance in metres required between individual ghost ship entities</summary>
/// <remarks>Full RCON name: <c>deepsea.ghostship_mindist</c></remarks>
public sealed class DeepseaGhostshipMindistCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.ghostship_mindist";

    /// <summary>Reads the current value of <c>deepsea.ghostship_mindist</c>.</summary>
    public static DeepseaGhostshipMindistCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaGhostshipMindistCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.ghostship_mindist</c> to <paramref name="value"/>.</summary>
    public static DeepseaGhostshipMindistCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DeepseaGhostshipMindistCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
