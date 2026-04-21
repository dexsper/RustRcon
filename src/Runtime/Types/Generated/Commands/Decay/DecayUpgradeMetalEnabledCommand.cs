using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Can players upgrade building blocks to metal</summary>
/// <remarks>Full RCON name: <c>decay.upgrade_metal_enabled</c></remarks>
public sealed class DecayUpgradeMetalEnabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.upgrade_metal_enabled";

    /// <summary>Reads the current value of <c>decay.upgrade_metal_enabled</c>.</summary>
    public static DecayUpgradeMetalEnabledCommand CreateGet()
    {
        var cmd = CreatePackage<DecayUpgradeMetalEnabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.upgrade_metal_enabled</c> to <paramref name="value"/>.</summary>
    public static DecayUpgradeMetalEnabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<DecayUpgradeMetalEnabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
