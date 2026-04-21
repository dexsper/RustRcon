using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of hackable crate entities to spawn in the deep sea zone as high-value loot targets</summary>
/// <remarks>Full RCON name: <c>deepsea.hackablecrate_count</c></remarks>
public sealed class DeepseaHackablecrateCountCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.hackablecrate_count";

    /// <summary>Reads the current value of <c>deepsea.hackablecrate_count</c>.</summary>
    public static DeepseaHackablecrateCountCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaHackablecrateCountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.hackablecrate_count</c> to <paramref name="value"/>.</summary>
    public static DeepseaHackablecrateCountCommand CreateSet(int value)
    {
        var cmd = CreatePackage<DeepseaHackablecrateCountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
