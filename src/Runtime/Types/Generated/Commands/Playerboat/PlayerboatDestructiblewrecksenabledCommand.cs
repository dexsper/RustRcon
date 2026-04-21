using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>playerboat.destructiblewrecksenabled</c>.</summary>
/// <remarks>Full RCON name: <c>playerboat.destructiblewrecksenabled</c></remarks>
public sealed class PlayerboatDestructiblewrecksenabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.destructiblewrecksenabled";

    /// <summary>Reads the current value of <c>playerboat.destructiblewrecksenabled</c>.</summary>
    public static PlayerboatDestructiblewrecksenabledCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerboatDestructiblewrecksenabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>playerboat.destructiblewrecksenabled</c> to <paramref name="value"/>.</summary>
    public static PlayerboatDestructiblewrecksenabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PlayerboatDestructiblewrecksenabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
