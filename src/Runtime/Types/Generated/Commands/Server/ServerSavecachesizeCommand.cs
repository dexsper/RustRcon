using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum byte size of the entity save cache used to accelerate autosaves; 0 means no hard limit</summary>
/// <remarks>Full RCON name: <c>server.savecachesize</c></remarks>
public sealed class ServerSavecachesizeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.savecachesize";

    /// <summary>Reads the current value of <c>server.savecachesize</c>.</summary>
    public static ServerSavecachesizeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerSavecachesizeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.savecachesize</c> to <paramref name="value"/>.</summary>
    public static ServerSavecachesizeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerSavecachesizeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
