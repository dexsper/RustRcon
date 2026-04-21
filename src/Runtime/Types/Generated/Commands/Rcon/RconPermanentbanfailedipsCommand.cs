using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Permanently ban IPs that trigger too many failed attempts (default: false)</summary>
/// <remarks>Full RCON name: <c>rcon.permanentbanfailedips</c></remarks>
public sealed class RconPermanentbanfailedipsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "rcon.permanentbanfailedips";

    /// <summary>Reads the current value of <c>rcon.permanentbanfailedips</c>.</summary>
    public static RconPermanentbanfailedipsCommand CreateGet()
    {
        var cmd = CreatePackage<RconPermanentbanfailedipsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>rcon.permanentbanfailedips</c> to <paramref name="value"/>.</summary>
    public static RconPermanentbanfailedipsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<RconPermanentbanfailedipsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
