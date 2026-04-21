using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>voice.voicerangeboostamount</c>.</summary>
/// <remarks>Full RCON name: <c>voice.voicerangeboostamount</c></remarks>
public sealed class VoiceVoicerangeboostamountCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "voice.voicerangeboostamount";

    /// <summary>Reads the current value of <c>voice.voicerangeboostamount</c>.</summary>
    public static VoiceVoicerangeboostamountCommand CreateGet()
    {
        var cmd = CreatePackage<VoiceVoicerangeboostamountCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>voice.voicerangeboostamount</c> to <paramref name="value"/>.</summary>
    public static VoiceVoicerangeboostamountCommand CreateSet(float value)
    {
        var cmd = CreatePackage<VoiceVoicerangeboostamountCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
