using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Can players upgrade building blocks to hqm</summary>
/// <remarks>Full RCON name: <c>decay.upgrade_hqm_enabled</c></remarks>
public sealed class DecayUpgradeHqmEnabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.upgrade_hqm_enabled";

    /// <summary>Reads the current value of <c>decay.upgrade_hqm_enabled</c>.</summary>
    public static DecayUpgradeHqmEnabledCommand CreateGet()
    {
        var cmd = CreatePackage<DecayUpgradeHqmEnabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.upgrade_hqm_enabled</c> to <paramref name="value"/>.</summary>
    public static DecayUpgradeHqmEnabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<DecayUpgradeHqmEnabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
