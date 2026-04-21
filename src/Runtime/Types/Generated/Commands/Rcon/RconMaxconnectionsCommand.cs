using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Total number of allowed connections to RCON server. -1 to disable behaviour. Requires server restart after changes</summary>
/// <remarks>Full RCON name: <c>rcon.maxconnections</c></remarks>
public sealed class RconMaxconnectionsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "rcon.maxconnections";

    /// <summary>Reads the current value of <c>rcon.maxconnections</c>.</summary>
    public static RconMaxconnectionsCommand CreateGet()
    {
        var cmd = CreatePackage<RconMaxconnectionsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>rcon.maxconnections</c> to <paramref name="value"/>.</summary>
    public static RconMaxconnectionsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<RconMaxconnectionsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
