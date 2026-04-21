using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The modifier by which a silencer reduce the noise that a gun makes when shot. (Default: 0.15)</summary>
/// <remarks>Full RCON name: <c>ai.npc_gun_noise_silencer_modifier</c></remarks>
public sealed class AiNpcGunNoiseSilencerModifierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_gun_noise_silencer_modifier";

    /// <summary>Reads the current value of <c>ai.npc_gun_noise_silencer_modifier</c>.</summary>
    public static AiNpcGunNoiseSilencerModifierCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcGunNoiseSilencerModifierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_gun_noise_silencer_modifier</c> to <paramref name="value"/>.</summary>
    public static AiNpcGunNoiseSilencerModifierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcGunNoiseSilencerModifierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
