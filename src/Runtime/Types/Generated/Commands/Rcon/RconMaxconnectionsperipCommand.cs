using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Total number of allowed connections to RCON server, on a single IP. -1 to disable behaviour. Requires server restart after changes</summary>
/// <remarks>Full RCON name: <c>rcon.maxconnectionsperip</c></remarks>
public sealed class RconMaxconnectionsperipCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "rcon.maxconnectionsperip";

    /// <summary>Reads the current value of <c>rcon.maxconnectionsperip</c>.</summary>
    public static RconMaxconnectionsperipCommand CreateGet()
    {
        var cmd = CreatePackage<RconMaxconnectionsperipCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>rcon.maxconnectionsperip</c> to <paramref name="value"/>.</summary>
    public static RconMaxconnectionsperipCommand CreateSet(int value)
    {
        var cmd = CreatePackage<RconMaxconnectionsperipCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
