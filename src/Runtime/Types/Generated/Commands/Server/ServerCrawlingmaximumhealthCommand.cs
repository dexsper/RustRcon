using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Maximum initial health given when a player dies and moves to crawling wounded state</summary>
/// <remarks>Full RCON name: <c>server.crawlingmaximumhealth</c></remarks>
public sealed class ServerCrawlingmaximumhealthCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.crawlingmaximumhealth";

    /// <summary>Reads the current value of <c>server.crawlingmaximumhealth</c>.</summary>
    public static ServerCrawlingmaximumhealthCommand CreateGet()
    {
        var cmd = CreatePackage<ServerCrawlingmaximumhealthCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.crawlingmaximumhealth</c> to <paramref name="value"/>.</summary>
    public static ServerCrawlingmaximumhealthCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerCrawlingmaximumhealthCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
