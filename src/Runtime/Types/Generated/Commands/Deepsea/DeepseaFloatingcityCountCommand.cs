using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of floating city structures to spawn in the deep sea; increase for more urban content, but each adds significant entity count</summary>
/// <remarks>Full RCON name: <c>deepsea.floatingcity_count</c></remarks>
public sealed class DeepseaFloatingcityCountCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.floatingcity_count";

    /// <summary>Reads the current value of <c>deepsea.floatingcity_count</c>.</summary>
    public static DeepseaFloatingcityCountCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaFloatingcityCountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.floatingcity_count</c> to <paramref name="value"/>.</summary>
    public static DeepseaFloatingcityCountCommand CreateSet(int value)
    {
        var cmd = CreatePackage<DeepseaFloatingcityCountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
