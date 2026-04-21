using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Multiplier for player metabolism tick frequency; lower values slow down hunger, thirst and calorie consumption rates</summary>
/// <remarks>Full RCON name: <c>server.metabolismtick</c></remarks>
public sealed class ServerMetabolismtickCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.metabolismtick";

    /// <summary>Reads the current value of <c>server.metabolismtick</c>.</summary>
    public static ServerMetabolismtickCommand CreateGet()
    {
        var cmd = CreatePackage<ServerMetabolismtickCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.metabolismtick</c> to <paramref name="value"/>.</summary>
    public static ServerMetabolismtickCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerMetabolismtickCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
