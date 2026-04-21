using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Can players upgrade building blocks to stone</summary>
/// <remarks>Full RCON name: <c>decay.upgrade_stone_enabled</c></remarks>
public sealed class DecayUpgradeStoneEnabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.upgrade_stone_enabled";

    /// <summary>Reads the current value of <c>decay.upgrade_stone_enabled</c>.</summary>
    public static DecayUpgradeStoneEnabledCommand CreateGet()
    {
        var cmd = CreatePackage<DecayUpgradeStoneEnabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.upgrade_stone_enabled</c> to <paramref name="value"/>.</summary>
    public static DecayUpgradeStoneEnabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<DecayUpgradeStoneEnabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
