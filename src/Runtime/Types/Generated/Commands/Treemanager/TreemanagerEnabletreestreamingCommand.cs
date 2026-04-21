using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, tree data is streamed to players based on proximity rather than sending all trees at connect; reduces initial bandwidth</summary>
/// <remarks>Full RCON name: <c>treemanager.enabletreestreaming</c></remarks>
public sealed class TreemanagerEnabletreestreamingCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "treemanager.enabletreestreaming";

    /// <summary>Reads the current value of <c>treemanager.enabletreestreaming</c>.</summary>
    public static TreemanagerEnabletreestreamingCommand CreateGet()
    {
        var cmd = CreatePackage<TreemanagerEnabletreestreamingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>treemanager.enabletreestreaming</c> to <paramref name="value"/>.</summary>
    public static TreemanagerEnabletreestreamingCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<TreemanagerEnabletreestreamingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
