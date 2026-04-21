using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum milliseconds per frame spent processing furnace and campfire cook ticks; lower values keep frames smoother on high-population servers</summary>
/// <remarks>Full RCON name: <c>server.ovencookbudgetms</c></remarks>
public sealed class ServerOvencookbudgetmsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.ovencookbudgetms";

    /// <summary>Reads the current value of <c>server.ovencookbudgetms</c>.</summary>
    public static ServerOvencookbudgetmsCommand CreateGet()
    {
        var cmd = CreatePackage<ServerOvencookbudgetmsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.ovencookbudgetms</c> to <paramref name="value"/>.</summary>
    public static ServerOvencookbudgetmsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerOvencookbudgetmsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
