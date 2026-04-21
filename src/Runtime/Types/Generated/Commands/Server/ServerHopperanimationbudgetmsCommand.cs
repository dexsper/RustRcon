using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long per frame to spend animating items moving into the hopper (will be instant if &lt;= 0)</summary>
/// <remarks>Full RCON name: <c>server.hopperanimationbudgetms</c></remarks>
public sealed class ServerHopperanimationbudgetmsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.hopperanimationbudgetms";

    /// <summary>Reads the current value of <c>server.hopperanimationbudgetms</c>.</summary>
    public static ServerHopperanimationbudgetmsCommand CreateGet()
    {
        var cmd = CreatePackage<ServerHopperanimationbudgetmsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.hopperanimationbudgetms</c> to <paramref name="value"/>.</summary>
    public static ServerHopperanimationbudgetmsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerHopperanimationbudgetmsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
