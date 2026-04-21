using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Total per-frame CPU budget in milliseconds for the tree streaming update system</summary>
/// <remarks>Full RCON name: <c>treemanager.updatebudgetms</c></remarks>
public sealed class TreemanagerUpdatebudgetmsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "treemanager.updatebudgetms";

    /// <summary>Reads the current value of <c>treemanager.updatebudgetms</c>.</summary>
    public static TreemanagerUpdatebudgetmsCommand CreateGet()
    {
        var cmd = CreatePackage<TreemanagerUpdatebudgetmsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>treemanager.updatebudgetms</c> to <paramref name="value"/>.</summary>
    public static TreemanagerUpdatebudgetmsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<TreemanagerUpdatebudgetmsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
