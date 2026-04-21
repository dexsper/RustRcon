using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Per-frame CPU budget in milliseconds allocated to sending tree streaming data per player</summary>
/// <remarks>Full RCON name: <c>treemanager.playerbudgetms</c></remarks>
public sealed class TreemanagerPlayerbudgetmsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "treemanager.playerbudgetms";

    /// <summary>Reads the current value of <c>treemanager.playerbudgetms</c>.</summary>
    public static TreemanagerPlayerbudgetmsCommand CreateGet()
    {
        var cmd = CreatePackage<TreemanagerPlayerbudgetmsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>treemanager.playerbudgetms</c> to <paramref name="value"/>.</summary>
    public static TreemanagerPlayerbudgetmsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<TreemanagerPlayerbudgetmsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
