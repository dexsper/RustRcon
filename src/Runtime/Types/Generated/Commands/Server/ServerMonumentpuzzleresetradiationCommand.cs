using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Allows radiation to flood monuments to force puzzles to reset</summary>
/// <remarks>Full RCON name: <c>server.monumentpuzzleresetradiation</c></remarks>
public sealed class ServerMonumentpuzzleresetradiationCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.monumentpuzzleresetradiation";

    /// <summary>Reads the current value of <c>server.monumentpuzzleresetradiation</c>.</summary>
    public static ServerMonumentpuzzleresetradiationCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMonumentpuzzleresetradiationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.monumentpuzzleresetradiation</c> to <paramref name="value"/>.</summary>
    public static ServerMonumentpuzzleresetradiationCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerMonumentpuzzleresetradiationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
