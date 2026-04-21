using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, players drop their backpack as a loot bag when they die; disable to prevent backpack loot from appearing on death</summary>
/// <remarks>Full RCON name: <c>player.dropbackpackondeath</c></remarks>
public sealed class PlayerDropbackpackondeathCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "player.dropbackpackondeath";

    /// <summary>Reads the current value of <c>player.dropbackpackondeath</c>.</summary>
    public static PlayerDropbackpackondeathCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerDropbackpackondeathCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>player.dropbackpackondeath</c> to <paramref name="value"/>.</summary>
    public static PlayerDropbackpackondeathCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PlayerDropbackpackondeathCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
