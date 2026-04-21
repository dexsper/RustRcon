using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, players drop their backpack when downed/wounded; disable to keep the backpack on the body until death or recovery</summary>
/// <remarks>Full RCON name: <c>player.dropbackpackondowned</c></remarks>
public sealed class PlayerDropbackpackondownedCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "player.dropbackpackondowned";

    /// <summary>Reads the current value of <c>player.dropbackpackondowned</c>.</summary>
    public static PlayerDropbackpackondownedCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerDropbackpackondownedCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>player.dropbackpackondowned</c> to <paramref name="value"/>.</summary>
    public static PlayerDropbackpackondownedCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PlayerDropbackpackondownedCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
