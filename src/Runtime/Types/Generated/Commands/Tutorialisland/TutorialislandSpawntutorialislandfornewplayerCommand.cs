using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>tutorialisland.spawntutorialislandfornewplayer</c>.</summary>
/// <remarks>Full RCON name: <c>tutorialisland.spawntutorialislandfornewplayer</c></remarks>
public sealed class TutorialislandSpawntutorialislandfornewplayerCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "tutorialisland.spawntutorialislandfornewplayer";

    /// <summary>Reads the current value of <c>tutorialisland.spawntutorialislandfornewplayer</c>.</summary>
    public static TutorialislandSpawntutorialislandfornewplayerCommand CreateGet()
    {
        var cmd = CreatePackage<TutorialislandSpawntutorialislandfornewplayerCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>tutorialisland.spawntutorialislandfornewplayer</c> to <paramref name="value"/>.</summary>
    public static TutorialislandSpawntutorialislandfornewplayerCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<TutorialislandSpawntutorialislandfornewplayerCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
