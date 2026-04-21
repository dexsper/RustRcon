using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of RHIB patrol boat groups to spawn in the deep sea zone</summary>
/// <remarks>Full RCON name: <c>deepsea.rhib_count</c></remarks>
public sealed class DeepseaRhibCountCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.rhib_count";

    /// <summary>Reads the current value of <c>deepsea.rhib_count</c>.</summary>
    public static DeepseaRhibCountCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaRhibCountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.rhib_count</c> to <paramref name="value"/>.</summary>
    public static DeepseaRhibCountCommand CreateSet(int value)
    {
        var cmd = CreatePackage<DeepseaRhibCountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
