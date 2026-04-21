using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.server_occlusion_disable_sleeper_los</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.server_occlusion_disable_sleeper_los</c></remarks>
public sealed class AntihackServerOcclusionDisableSleeperLosCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.server_occlusion_disable_sleeper_los";

    /// <summary>Reads the current value of <c>antihack.server_occlusion_disable_sleeper_los</c>.</summary>
    public static AntihackServerOcclusionDisableSleeperLosCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackServerOcclusionDisableSleeperLosCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.server_occlusion_disable_sleeper_los</c> to <paramref name="value"/>.</summary>
    public static AntihackServerOcclusionDisableSleeperLosCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackServerOcclusionDisableSleeperLosCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
