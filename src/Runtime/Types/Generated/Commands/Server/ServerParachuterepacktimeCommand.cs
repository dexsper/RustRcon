using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long it takes to pick up a used parachute in seconds</summary>
/// <remarks>Full RCON name: <c>server.parachuterepacktime</c></remarks>
public sealed class ServerParachuterepacktimeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.parachuterepacktime";

    /// <summary>Reads the current value of <c>server.parachuterepacktime</c>.</summary>
    public static ServerParachuterepacktimeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerParachuterepacktimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.parachuterepacktime</c> to <paramref name="value"/>.</summary>
    public static ServerParachuterepacktimeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerParachuterepacktimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
