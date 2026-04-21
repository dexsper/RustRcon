using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>deepsea.block_building</c>.</summary>
/// <remarks>Full RCON name: <c>deepsea.block_building</c></remarks>
public sealed class DeepseaBlockBuildingCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.block_building";

    /// <summary>Reads the current value of <c>deepsea.block_building</c>.</summary>
    public static DeepseaBlockBuildingCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaBlockBuildingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.block_building</c> to <paramref name="value"/>.</summary>
    public static DeepseaBlockBuildingCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<DeepseaBlockBuildingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
