using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Sets the EOS (Epic Online Services) anti-cheat log verbosity level; higher values produce more detailed anti-cheat diagnostic output</summary>
/// <remarks>Full RCON name: <c>server.anticheatlog</c></remarks>
public sealed class ServerAnticheatlogCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.anticheatlog";

    /// <summary>Reads the current value of <c>server.anticheatlog</c>.</summary>
    public static ServerAnticheatlogCommand CreateGet()
    {
        var cmd = CreatePackage<ServerAnticheatlogCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.anticheatlog</c> to <paramref name="value"/>.</summary>
    public static ServerAnticheatlogCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerAnticheatlogCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
