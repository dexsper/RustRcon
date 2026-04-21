using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Maximum number of members each clan can have (local backend only!)</summary>
/// <remarks>Full RCON name: <c>clan.maxmembercount</c></remarks>
public sealed class ClanMaxmembercountCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "clan.maxmembercount";

    /// <summary>Reads the current value of <c>clan.maxmembercount</c>.</summary>
    public static ClanMaxmembercountCommand CreateGet()
    {
        var cmd = CreatePackage<ClanMaxmembercountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>clan.maxmembercount</c> to <paramref name="value"/>.</summary>
    public static ClanMaxmembercountCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ClanMaxmembercountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
