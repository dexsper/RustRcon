using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Secondary salt value mixed into procedural world generation; used to vary monument and road placement</summary>
/// <remarks>Full RCON name: <c>server.salt</c></remarks>
public sealed class ServerSaltCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.salt";

    /// <summary>Reads the current value of <c>server.salt</c>.</summary>
    public static ServerSaltCommand CreateGet()
    {
        var cmd = CreatePackage<ServerSaltCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.salt</c> to <paramref name="value"/>.</summary>
    public static ServerSaltCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerSaltCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
