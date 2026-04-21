using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Maximum number of players to recheck at a time</summary>
/// <remarks>Full RCON name: <c>server.premiumrecheckmaxbatchsize</c></remarks>
public sealed class ServerPremiumrecheckmaxbatchsizeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.premiumrecheckmaxbatchsize";

    /// <summary>Reads the current value of <c>server.premiumrecheckmaxbatchsize</c>.</summary>
    public static ServerPremiumrecheckmaxbatchsizeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPremiumrecheckmaxbatchsizeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.premiumrecheckmaxbatchsize</c> to <paramref name="value"/>.</summary>
    public static ServerPremiumrecheckmaxbatchsizeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerPremiumrecheckmaxbatchsizeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
