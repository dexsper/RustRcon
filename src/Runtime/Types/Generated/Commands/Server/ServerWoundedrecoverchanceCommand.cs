using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Base chance of recovery after crawling wounded state</summary>
/// <remarks>Full RCON name: <c>server.woundedrecoverchance</c></remarks>
public sealed class ServerWoundedrecoverchanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.woundedrecoverchance";

    /// <summary>Reads the current value of <c>server.woundedrecoverchance</c>.</summary>
    public static ServerWoundedrecoverchanceCommand CreateGet()
    {
        var cmd = CreatePackage<ServerWoundedrecoverchanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.woundedrecoverchance</c> to <paramref name="value"/>.</summary>
    public static ServerWoundedrecoverchanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerWoundedrecoverchanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
