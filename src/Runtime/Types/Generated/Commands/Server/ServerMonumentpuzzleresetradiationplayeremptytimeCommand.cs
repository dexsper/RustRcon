using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long does a monument puzzle need to be empty with full rads before it can reset</summary>
/// <remarks>Full RCON name: <c>server.monumentpuzzleresetradiationplayeremptytime</c></remarks>
public sealed class ServerMonumentpuzzleresetradiationplayeremptytimeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.monumentpuzzleresetradiationplayeremptytime";

    /// <summary>Reads the current value of <c>server.monumentpuzzleresetradiationplayeremptytime</c>.</summary>
    public static ServerMonumentpuzzleresetradiationplayeremptytimeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMonumentpuzzleresetradiationplayeremptytimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.monumentpuzzleresetradiationplayeremptytime</c> to <paramref name="value"/>.</summary>
    public static ServerMonumentpuzzleresetradiationplayeremptytimeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerMonumentpuzzleresetradiationplayeremptytimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
