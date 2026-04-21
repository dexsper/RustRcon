using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Include bots in the admin UI player list (debugging purpose only)</summary>
/// <remarks>Full RCON name: <c>global.showbotsinplayerlist</c></remarks>
public sealed class GlobalShowbotsinplayerlistCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.showbotsinplayerlist";

    /// <summary>Reads the current value of <c>global.showbotsinplayerlist</c>.</summary>
    public static GlobalShowbotsinplayerlistCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalShowbotsinplayerlistCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.showbotsinplayerlist</c> to <paramref name="value"/>.</summary>
    public static GlobalShowbotsinplayerlistCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<GlobalShowbotsinplayerlistCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
