using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) How frequently in seconds the NPC sensory system updates its awareness of nearby entities; higher values reduce CPU cost but make NPCs slower to react</summary>
/// <remarks>Full RCON name: <c>ai.sensetime</c></remarks>
public sealed class AiSensetimeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.sensetime";

    /// <summary>Reads the current value of <c>ai.sensetime</c>.</summary>
    public static AiSensetimeCommand CreateGet()
    {
        var cmd = CreatePackage<AiSensetimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.sensetime</c> to <paramref name="value"/>.</summary>
    public static AiSensetimeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiSensetimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
