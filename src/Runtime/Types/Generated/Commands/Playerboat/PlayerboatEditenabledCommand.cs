using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>playerboat.editenabled</c>.</summary>
/// <remarks>Full RCON name: <c>playerboat.editenabled</c></remarks>
public sealed class PlayerboatEditenabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.editenabled";

    /// <summary>Reads the current value of <c>playerboat.editenabled</c>.</summary>
    public static PlayerboatEditenabledCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerboatEditenabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>playerboat.editenabled</c> to <paramref name="value"/>.</summary>
    public static PlayerboatEditenabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PlayerboatEditenabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
