using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Enables the clan system if set to true (must be set at boot, requires restart)</summary>
/// <remarks>Full RCON name: <c>clan.enabled</c></remarks>
public sealed class ClanEnabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "clan.enabled";

    /// <summary>Reads the current value of <c>clan.enabled</c>.</summary>
    public static ClanEnabledCommand CreateGet()
    {
        var cmd = CreatePackage<ClanEnabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>clan.enabled</c> to <paramref name="value"/>.</summary>
    public static ClanEnabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ClanEnabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
