using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Duration in seconds after entering the deep sea zone that a player boat has before its engine is powered down</summary>
/// <remarks>Full RCON name: <c>playerboat.deepseatransitionpowerdowngraceduration</c></remarks>
public sealed class PlayerboatDeepseatransitionpowerdowngracedurationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.deepseatransitionpowerdowngraceduration";

    /// <summary>Reads the current value of <c>playerboat.deepseatransitionpowerdowngraceduration</c>.</summary>
    public static PlayerboatDeepseatransitionpowerdowngracedurationCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerboatDeepseatransitionpowerdowngracedurationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>playerboat.deepseatransitionpowerdowngraceduration</c> to <paramref name="value"/>.</summary>
    public static PlayerboatDeepseatransitionpowerdowngracedurationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<PlayerboatDeepseatransitionpowerdowngracedurationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
