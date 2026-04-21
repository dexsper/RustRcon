using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.server_occlusion_caching</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.server_occlusion_caching</c></remarks>
public sealed class AntihackServerOcclusionCachingCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.server_occlusion_caching";

    /// <summary>Reads the current value of <c>antihack.server_occlusion_caching</c>.</summary>
    public static AntihackServerOcclusionCachingCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackServerOcclusionCachingCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.server_occlusion_caching</c> to <paramref name="value"/>.</summary>
    public static AntihackServerOcclusionCachingCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackServerOcclusionCachingCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
