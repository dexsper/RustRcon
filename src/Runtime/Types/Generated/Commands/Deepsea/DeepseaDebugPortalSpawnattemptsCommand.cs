using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, logs each deep sea portal spawn attempt to the console including whether it succeeded or failed; useful for diagnosing portal placement issues</summary>
/// <remarks>Full RCON name: <c>deepsea.debug_portal_spawnattempts</c></remarks>
public sealed class DeepseaDebugPortalSpawnattemptsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.debug_portal_spawnattempts";

    /// <summary>Reads the current value of <c>deepsea.debug_portal_spawnattempts</c>.</summary>
    public static DeepseaDebugPortalSpawnattemptsCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaDebugPortalSpawnattemptsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.debug_portal_spawnattempts</c> to <paramref name="value"/>.</summary>
    public static DeepseaDebugPortalSpawnattemptsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<DeepseaDebugPortalSpawnattemptsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
