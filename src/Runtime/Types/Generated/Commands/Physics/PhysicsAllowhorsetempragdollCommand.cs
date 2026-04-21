using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, horses can be temporarily ragdolled by large physics impacts; disabling keeps horses upright during collisions</summary>
/// <remarks>Full RCON name: <c>physics.allowhorsetempragdoll</c></remarks>
public sealed class PhysicsAllowhorsetempragdollCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physics.allowhorsetempragdoll";

    /// <summary>Reads the current value of <c>physics.allowhorsetempragdoll</c>.</summary>
    public static PhysicsAllowhorsetempragdollCommand CreateGet()
    {
        var cmd = CreatePackage<PhysicsAllowhorsetempragdollCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>physics.allowhorsetempragdoll</c> to <paramref name="value"/>.</summary>
    public static PhysicsAllowhorsetempragdollCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PhysicsAllowhorsetempragdollCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
