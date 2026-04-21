using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>ai.allowdesigning</c>.</summary>
/// <remarks>Full RCON name: <c>ai.allowdesigning</c></remarks>
public sealed class AiAllowdesigningCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.allowdesigning";

    /// <summary>Reads the current value of <c>ai.allowdesigning</c>.</summary>
    public static AiAllowdesigningCommand CreateGet()
    {
        var cmd = CreatePackage<AiAllowdesigningCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.allowdesigning</c> to <paramref name="value"/>.</summary>
    public static AiAllowdesigningCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiAllowdesigningCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
