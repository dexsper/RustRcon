using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Multiplier for impulse applied to players when ragdolled by this entity</summary>
/// <remarks>Full RCON name: <c>physicstumblingentity.player_impulse_multiplier</c></remarks>
public sealed class PhysicstumblingentityPlayerImpulseMultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "physicstumblingentity.player_impulse_multiplier";

    /// <summary>Reads the current value of <c>physicstumblingentity.player_impulse_multiplier</c>.</summary>
    public static PhysicstumblingentityPlayerImpulseMultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<PhysicstumblingentityPlayerImpulseMultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>physicstumblingentity.player_impulse_multiplier</c> to <paramref name="value"/>.</summary>
    public static PhysicstumblingentityPlayerImpulseMultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PhysicstumblingentityPlayerImpulseMultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
