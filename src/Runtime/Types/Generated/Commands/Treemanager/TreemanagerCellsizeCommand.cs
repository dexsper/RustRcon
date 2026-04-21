using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Define cell size(in m) of a grid for trees  - only has effect on world load and must be &gt; 1. This affects how much data we send per tree cell(bigger the cell - more trees we have to send). The smaller the cell, the more cells we have to process and the more memory we need per player to track what's left to send(gridSize ^ 2 / 8 bytes). We readjust CellSize to ensure gridSize never exceeds 512.</summary>
/// <remarks>Full RCON name: <c>treemanager.cellsize</c></remarks>
public sealed class TreemanagerCellsizeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "treemanager.cellsize";

    /// <summary>Reads the current value of <c>treemanager.cellsize</c>.</summary>
    public static TreemanagerCellsizeCommand CreateGet()
    {
        var cmd = CreatePackage<TreemanagerCellsizeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>treemanager.cellsize</c> to <paramref name="value"/>.</summary>
    public static TreemanagerCellsizeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<TreemanagerCellsizeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
