using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long before the reset happens do we start applying radiation</summary>
/// <remarks>Full RCON name: <c>server.monumentpuzzleresetradiationpreresettime</c></remarks>
public sealed class ServerMonumentpuzzleresetradiationpreresettimeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.monumentpuzzleresetradiationpreresettime";

    /// <summary>Reads the current value of <c>server.monumentpuzzleresetradiationpreresettime</c>.</summary>
    public static ServerMonumentpuzzleresetradiationpreresettimeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMonumentpuzzleresetradiationpreresettimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.monumentpuzzleresetradiationpreresettime</c> to <paramref name="value"/>.</summary>
    public static ServerMonumentpuzzleresetradiationpreresettimeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerMonumentpuzzleresetradiationpreresettimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
