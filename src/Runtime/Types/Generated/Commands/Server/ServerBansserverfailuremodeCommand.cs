using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Failure mode for centralized banning, set to 1 to reject players from joining if it's down (see wiki)</summary>
/// <remarks>Full RCON name: <c>server.bansserverfailuremode</c></remarks>
public sealed class ServerBansserverfailuremodeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.bansserverfailuremode";

    /// <summary>Reads the current value of <c>server.bansserverfailuremode</c>.</summary>
    public static ServerBansserverfailuremodeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerBansserverfailuremodeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.bansserverfailuremode</c> to <paramref name="value"/>.</summary>
    public static ServerBansserverfailuremodeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerBansserverfailuremodeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
