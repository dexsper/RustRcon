using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Force enable radiation in monument puzzles to confirm they work</summary>
/// <remarks>Full RCON name: <c>server.monumentpuzzleresetradiationoverride</c></remarks>
public sealed class ServerMonumentpuzzleresetradiationoverrideCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.monumentpuzzleresetradiationoverride";

    /// <summary>Reads the current value of <c>server.monumentpuzzleresetradiationoverride</c>.</summary>
    public static ServerMonumentpuzzleresetradiationoverrideCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMonumentpuzzleresetradiationoverrideCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.monumentpuzzleresetradiationoverride</c> to <paramref name="value"/>.</summary>
    public static ServerMonumentpuzzleresetradiationoverrideCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerMonumentpuzzleresetradiationoverrideCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
