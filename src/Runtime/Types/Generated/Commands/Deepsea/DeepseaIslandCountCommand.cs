using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of small islands to spawn in the deep sea zone</summary>
/// <remarks>Full RCON name: <c>deepsea.island_count</c></remarks>
public sealed class DeepseaIslandCountCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.island_count";

    /// <summary>Reads the current value of <c>deepsea.island_count</c>.</summary>
    public static DeepseaIslandCountCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaIslandCountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.island_count</c> to <paramref name="value"/>.</summary>
    public static DeepseaIslandCountCommand CreateSet(int value)
    {
        var cmd = CreatePackage<DeepseaIslandCountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
