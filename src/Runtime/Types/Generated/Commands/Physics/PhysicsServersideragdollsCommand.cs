using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Do ragdoll physics calculations on the server, or use the old client-side system</summary>
/// <remarks>Full RCON name: <c>physics.serversideragdolls</c></remarks>
public sealed class PhysicsServersideragdollsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physics.serversideragdolls";

    /// <summary>Reads the current value of <c>physics.serversideragdolls</c>.</summary>
    public static PhysicsServersideragdollsCommand CreateGet()
    {
        var cmd = CreatePackage<PhysicsServersideragdollsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>physics.serversideragdolls</c> to <paramref name="value"/>.</summary>
    public static PhysicsServersideragdollsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PhysicsServersideragdollsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
