using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>server.bag_quota_item_amount</c>.</summary>
/// <remarks>Full RCON name: <c>server.bag_quota_item_amount</c></remarks>
public sealed class ServerBagQuotaItemAmountCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.bag_quota_item_amount";

    /// <summary>Reads the current value of <c>server.bag_quota_item_amount</c>.</summary>
    public static ServerBagQuotaItemAmountCommand CreateGet()
    {
        var cmd = CreatePackage<ServerBagQuotaItemAmountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.bag_quota_item_amount</c> to <paramref name="value"/>.</summary>
    public static ServerBagQuotaItemAmountCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerBagQuotaItemAmountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
