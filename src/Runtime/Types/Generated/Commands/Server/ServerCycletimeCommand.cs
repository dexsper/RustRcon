using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Duration of a full day/night cycle in seconds; default 500s means roughly one cycle every 8 real-world minutes</summary>
/// <remarks>Full RCON name: <c>server.cycletime</c></remarks>
public sealed class ServerCycletimeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.cycletime";

    /// <summary>Reads the current value of <c>server.cycletime</c>.</summary>
    public static ServerCycletimeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerCycletimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.cycletime</c> to <paramref name="value"/>.</summary>
    public static ServerCycletimeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerCycletimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
