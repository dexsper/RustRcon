using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long per frame to spend on updating water wheel power generation and water info</summary>
/// <remarks>Full RCON name: <c>server.waterwheelworkbudgetms</c></remarks>
public sealed class ServerWaterwheelworkbudgetmsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.waterwheelworkbudgetms";

    /// <summary>Reads the current value of <c>server.waterwheelworkbudgetms</c>.</summary>
    public static ServerWaterwheelworkbudgetmsCommand CreateGet()
    {
        var cmd = CreatePackage<ServerWaterwheelworkbudgetmsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.waterwheelworkbudgetms</c> to <paramref name="value"/>.</summary>
    public static ServerWaterwheelworkbudgetmsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerWaterwheelworkbudgetmsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
