using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, tea/buff effects active on a player at the time of death are carried over to their next life instead of being lost</summary>
/// <remarks>Full RCON name: <c>player.keepteaondeath</c></remarks>
public sealed class PlayerKeepteaondeathCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "player.keepteaondeath";

    /// <summary>Reads the current value of <c>player.keepteaondeath</c>.</summary>
    public static PlayerKeepteaondeathCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerKeepteaondeathCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>player.keepteaondeath</c> to <paramref name="value"/>.</summary>
    public static PlayerKeepteaondeathCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PlayerKeepteaondeathCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
