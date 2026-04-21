using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of ghost ship entities to spawn in the deep sea zone</summary>
/// <remarks>Full RCON name: <c>deepsea.ghostship_count</c></remarks>
public sealed class DeepseaGhostshipCountCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.ghostship_count";

    /// <summary>Reads the current value of <c>deepsea.ghostship_count</c>.</summary>
    public static DeepseaGhostshipCountCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaGhostshipCountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.ghostship_count</c> to <paramref name="value"/>.</summary>
    public static DeepseaGhostshipCountCommand CreateSet(int value)
    {
        var cmd = CreatePackage<DeepseaGhostshipCountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
