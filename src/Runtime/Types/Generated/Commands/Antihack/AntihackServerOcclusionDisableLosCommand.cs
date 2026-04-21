using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.server_occlusion_disable_los</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.server_occlusion_disable_los</c></remarks>
public sealed class AntihackServerOcclusionDisableLosCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.server_occlusion_disable_los";

    /// <summary>Reads the current value of <c>antihack.server_occlusion_disable_los</c>.</summary>
    public static AntihackServerOcclusionDisableLosCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackServerOcclusionDisableLosCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.server_occlusion_disable_los</c> to <paramref name="value"/>.</summary>
    public static AntihackServerOcclusionDisableLosCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackServerOcclusionDisableLosCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
