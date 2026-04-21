using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, AI entities ignore player presence and will not target or react to players; useful for building/testing without NPC interference</summary>
/// <remarks>Full RCON name: <c>ai.ignoreplayers</c></remarks>
public sealed class AiIgnoreplayersCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.ignoreplayers";

    /// <summary>Reads the current value of <c>ai.ignoreplayers</c>.</summary>
    public static AiIgnoreplayersCommand CreateGet()
    {
        var cmd = CreatePackage<AiIgnoreplayersCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.ignoreplayers</c> to <paramref name="value"/>.</summary>
    public static AiIgnoreplayersCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiIgnoreplayersCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
