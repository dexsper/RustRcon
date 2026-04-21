using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>npc_cover_compromised_cooldown defines how long a cover point is marked as compromised before it's cleared again for selection. (default: 10)</summary>
/// <remarks>Full RCON name: <c>ai.npc_cover_compromised_cooldown</c></remarks>
public sealed class AiNpcCoverCompromisedCooldownCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_cover_compromised_cooldown";

    /// <summary>Reads the current value of <c>ai.npc_cover_compromised_cooldown</c>.</summary>
    public static AiNpcCoverCompromisedCooldownCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcCoverCompromisedCooldownCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_cover_compromised_cooldown</c> to <paramref name="value"/>.</summary>
    public static AiNpcCoverCompromisedCooldownCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcCoverCompromisedCooldownCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
