using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Whether the crawling state expires</summary>
/// <remarks>Full RCON name: <c>player.woundforever</c></remarks>
public sealed class PlayerWoundforeverCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "player.woundforever";

    /// <summary>Reads the current value of <c>player.woundforever</c>.</summary>
    public static PlayerWoundforeverCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerWoundforeverCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>player.woundforever</c> to <paramref name="value"/>.</summary>
    public static PlayerWoundforeverCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PlayerWoundforeverCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
