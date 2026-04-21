using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Maximum amount of time in seconds that transfers should be cached before auto-saving</summary>
/// <remarks>Full RCON name: <c>nexus.transferflushtime</c></remarks>
public sealed class NexusTransferflushtimeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "nexus.transferflushtime";

    /// <summary>Reads the current value of <c>nexus.transferflushtime</c>.</summary>
    public static NexusTransferflushtimeCommand CreateGet()
    {
        var cmd = CreatePackage<NexusTransferflushtimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>nexus.transferflushtime</c> to <paramref name="value"/>.</summary>
    public static NexusTransferflushtimeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<NexusTransferflushtimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
