using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, tree harvest events are broadcast to all connected clients, not just nearby players; useful for testing tree sync across the network</summary>
/// <remarks>Full RCON name: <c>tree.global_broadcast</c></remarks>
public sealed class TreeGlobalBroadcastCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "tree.global_broadcast";

    /// <summary>Reads the current value of <c>tree.global_broadcast</c>.</summary>
    public static TreeGlobalBroadcastCommand CreateGet()
    {
        var cmd = CreatePackage<TreeGlobalBroadcastCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>tree.global_broadcast</c> to <paramref name="value"/>.</summary>
    public static TreeGlobalBroadcastCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<TreeGlobalBroadcastCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
