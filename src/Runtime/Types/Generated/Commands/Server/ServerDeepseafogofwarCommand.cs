using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Should the deep sea map be covered by fog of war</summary>
/// <remarks>Full RCON name: <c>server.deepseafogofwar</c></remarks>
public sealed class ServerDeepseafogofwarCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.deepseafogofwar";

    /// <summary>Reads the current value of <c>server.deepseafogofwar</c>.</summary>
    public static ServerDeepseafogofwarCommand CreateGet()
    {
        var cmd = CreatePackage<ServerDeepseafogofwarCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.deepseafogofwar</c> to <paramref name="value"/>.</summary>
    public static ServerDeepseafogofwarCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerDeepseafogofwarCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
