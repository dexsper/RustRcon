using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Radiation damage per second applied to players inside a monument during its puzzle-reset radiation phase</summary>
/// <remarks>Full RCON name: <c>server.monumentpuzzleresetradiationamount</c></remarks>
public sealed class ServerMonumentpuzzleresetradiationamountCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.monumentpuzzleresetradiationamount";

    /// <summary>Reads the current value of <c>server.monumentpuzzleresetradiationamount</c>.</summary>
    public static ServerMonumentpuzzleresetradiationamountCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMonumentpuzzleresetradiationamountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.monumentpuzzleresetradiationamount</c> to <paramref name="value"/>.</summary>
    public static ServerMonumentpuzzleresetradiationamountCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerMonumentpuzzleresetradiationamountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
