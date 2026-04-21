using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If a player sprays more than this, the oldest spray will be destroyed. 0 will disable</summary>
/// <remarks>Full RCON name: <c>global.maxspraysperplayer</c></remarks>
public sealed class GlobalMaxspraysperplayerCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.maxspraysperplayer";

    /// <summary>Reads the current value of <c>global.maxspraysperplayer</c>.</summary>
    public static GlobalMaxspraysperplayerCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalMaxspraysperplayerCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.maxspraysperplayer</c> to <paramref name="value"/>.</summary>
    public static GlobalMaxspraysperplayerCommand CreateSet(int value)
    {
        var cmd = CreatePackage<GlobalMaxspraysperplayerCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
