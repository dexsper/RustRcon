using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>global.steamstatus</c>.</summary>
/// <remarks>Full RCON name: <c>global.steamstatus</c></remarks>
public sealed class GlobalSteamstatusCommand : BaseCallCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.steamstatus";

    /// <summary>Creates a new <see cref="GlobalSteamstatusCommand"/> command.</summary>
    public static GlobalSteamstatusCommand Create()
    {
        var cmd = CreatePackage<GlobalSteamstatusCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
