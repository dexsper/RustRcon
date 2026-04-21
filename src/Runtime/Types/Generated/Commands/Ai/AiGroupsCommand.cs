using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, AI group logic is active allowing NPCs to coordinate as squads; disable to make all NPCs act as independent individuals</summary>
/// <remarks>Full RCON name: <c>ai.groups</c></remarks>
public sealed class AiGroupsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.groups";

    /// <summary>Reads the current value of <c>ai.groups</c>.</summary>
    public static AiGroupsCommand CreateGet()
    {
        var cmd = CreatePackage<AiGroupsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.groups</c> to <paramref name="value"/>.</summary>
    public static AiGroupsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiGroupsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
