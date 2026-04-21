using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If true hot air balloons can be shot down with homing missiles</summary>
/// <remarks>Full RCON name: <c>server.homingmissiletargetshab</c></remarks>
public sealed class ServerHomingmissiletargetshabCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.homingmissiletargetshab";

    /// <summary>Reads the current value of <c>server.homingmissiletargetshab</c>.</summary>
    public static ServerHomingmissiletargetshabCommand CreateGet()
    {
        var cmd = CreatePackage<ServerHomingmissiletargetshabCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.homingmissiletargetshab</c> to <paramref name="value"/>.</summary>
    public static ServerHomingmissiletargetshabCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerHomingmissiletargetshabCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
