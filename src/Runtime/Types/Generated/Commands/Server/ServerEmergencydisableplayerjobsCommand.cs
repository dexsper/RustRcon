using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Runs extra validation checks to prevent crashes and instead switch back to vanilla processing</summary>
/// <remarks>Full RCON name: <c>server.emergencydisableplayerjobs</c></remarks>
public sealed class ServerEmergencydisableplayerjobsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.emergencydisableplayerjobs";

    /// <summary>Reads the current value of <c>server.emergencydisableplayerjobs</c>.</summary>
    public static ServerEmergencydisableplayerjobsCommand CreateGet()
    {
        var cmd = CreatePackage<ServerEmergencydisableplayerjobsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.emergencydisableplayerjobs</c> to <paramref name="value"/>.</summary>
    public static ServerEmergencydisableplayerjobsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerEmergencydisableplayerjobsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
