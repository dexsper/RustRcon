using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, players can be temporarily ragdolled by large physics impacts (e.g. explosions) before recovering; disabling keeps players standing</summary>
/// <remarks>Full RCON name: <c>physics.allowplayertempragdoll</c></remarks>
public sealed class PhysicsAllowplayertempragdollCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physics.allowplayertempragdoll";

    /// <summary>Reads the current value of <c>physics.allowplayertempragdoll</c>.</summary>
    public static PhysicsAllowplayertempragdollCommand CreateGet()
    {
        var cmd = CreatePackage<PhysicsAllowplayertempragdollCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>physics.allowplayertempragdoll</c> to <paramref name="value"/>.</summary>
    public static PhysicsAllowplayertempragdollCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PhysicsAllowplayertempragdollCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
