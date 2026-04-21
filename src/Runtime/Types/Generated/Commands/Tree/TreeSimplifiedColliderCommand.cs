using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, trees use a simplified capsule collider instead of the full mesh collider, reducing physics CPU cost at the expense of collision accuracy</summary>
/// <remarks>Full RCON name: <c>tree.simplified_collider</c></remarks>
public sealed class TreeSimplifiedColliderCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "tree.simplified_collider";

    /// <summary>Reads the current value of <c>tree.simplified_collider</c>.</summary>
    public static TreeSimplifiedColliderCommand CreateGet()
    {
        var cmd = CreatePackage<TreeSimplifiedColliderCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>tree.simplified_collider</c> to <paramref name="value"/>.</summary>
    public static TreeSimplifiedColliderCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<TreeSimplifiedColliderCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
