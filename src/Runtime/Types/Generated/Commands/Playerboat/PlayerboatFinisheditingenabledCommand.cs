using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>playerboat.finisheditingenabled</c>.</summary>
/// <remarks>Full RCON name: <c>playerboat.finisheditingenabled</c></remarks>
public sealed class PlayerboatFinisheditingenabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.finisheditingenabled";

    /// <summary>Reads the current value of <c>playerboat.finisheditingenabled</c>.</summary>
    public static PlayerboatFinisheditingenabledCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerboatFinisheditingenabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>playerboat.finisheditingenabled</c> to <paramref name="value"/>.</summary>
    public static PlayerboatFinisheditingenabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PlayerboatFinisheditingenabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
