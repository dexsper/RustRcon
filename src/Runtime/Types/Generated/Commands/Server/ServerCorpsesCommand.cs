using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Whether player corpses are spawned when players die; disabling removes corpses entirely and items are dropped directly</summary>
/// <remarks>Full RCON name: <c>server.corpses</c></remarks>
public sealed class ServerCorpsesCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.corpses";

    /// <summary>Reads the current value of <c>server.corpses</c>.</summary>
    public static ServerCorpsesCommand CreateGet()
    {
        var cmd = CreatePackage<ServerCorpsesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.corpses</c> to <paramref name="value"/>.</summary>
    public static ServerCorpsesCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerCorpsesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
