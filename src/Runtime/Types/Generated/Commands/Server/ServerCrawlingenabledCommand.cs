using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Do players go into the crawling wounded state</summary>
/// <remarks>Full RCON name: <c>server.crawlingenabled</c></remarks>
public sealed class ServerCrawlingenabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.crawlingenabled";

    /// <summary>Reads the current value of <c>server.crawlingenabled</c>.</summary>
    public static ServerCrawlingenabledCommand CreateGet()
    {
        var cmd = CreatePackage<ServerCrawlingenabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.crawlingenabled</c> to <paramref name="value"/>.</summary>
    public static ServerCrawlingenabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerCrawlingenabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
