using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Multiplier applied to a monument's normal radiation radius when the puzzle-reset radiation cloud is active; default 1.5x expands the zone beyond its usual boundary</summary>
/// <remarks>Full RCON name: <c>server.monumentpuzzleresetradiationradiusmultiplier</c></remarks>
public sealed class ServerMonumentpuzzleresetradiationradiusmultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.monumentpuzzleresetradiationradiusmultiplier";

    /// <summary>Reads the current value of <c>server.monumentpuzzleresetradiationradiusmultiplier</c>.</summary>
    public static ServerMonumentpuzzleresetradiationradiusmultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMonumentpuzzleresetradiationradiusmultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.monumentpuzzleresetradiationradiusmultiplier</c> to <paramref name="value"/>.</summary>
    public static ServerMonumentpuzzleresetradiationradiusmultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerMonumentpuzzleresetradiationradiusmultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
