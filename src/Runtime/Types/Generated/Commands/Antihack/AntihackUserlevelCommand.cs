using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.userlevel</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.userlevel</c></remarks>
public sealed class AntihackUserlevelCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.userlevel";

    /// <summary>Reads the current value of <c>antihack.userlevel</c>.</summary>
    public static AntihackUserlevelCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackUserlevelCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.userlevel</c> to <paramref name="value"/>.</summary>
    public static AntihackUserlevelCommand CreateSet(int value)
    {
        var cmd = CreatePackage<AntihackUserlevelCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
