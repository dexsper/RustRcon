using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Can players upgrade building blocks to wood</summary>
/// <remarks>Full RCON name: <c>decay.upgrade_wood_enabled</c></remarks>
public sealed class DecayUpgradeWoodEnabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.upgrade_wood_enabled";

    /// <summary>Reads the current value of <c>decay.upgrade_wood_enabled</c>.</summary>
    public static DecayUpgradeWoodEnabledCommand CreateGet()
    {
        var cmd = CreatePackage<DecayUpgradeWoodEnabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.upgrade_wood_enabled</c> to <paramref name="value"/>.</summary>
    public static DecayUpgradeWoodEnabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<DecayUpgradeWoodEnabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
