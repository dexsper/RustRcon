using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Minimum initial health given when a player dies and moves to crawling wounded state</summary>
/// <remarks>Full RCON name: <c>server.crawlingminimumhealth</c></remarks>
public sealed class ServerCrawlingminimumhealthCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.crawlingminimumhealth";

    /// <summary>Reads the current value of <c>server.crawlingminimumhealth</c>.</summary>
    public static ServerCrawlingminimumhealthCommand CreateGet()
    {
        var cmd = CreatePackage<ServerCrawlingminimumhealthCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.crawlingminimumhealth</c> to <paramref name="value"/>.</summary>
    public static ServerCrawlingminimumhealthCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerCrawlingminimumhealthCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
