using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>player.tickrate_cl</c>.</summary>
/// <remarks>Full RCON name: <c>player.tickrate_cl</c></remarks>
public sealed class PlayerTickrateClCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "player.tickrate_cl";

    /// <summary>Reads the current value of <c>player.tickrate_cl</c>.</summary>
    public static PlayerTickrateClCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerTickrateClCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>player.tickrate_cl</c> to <paramref name="value"/>.</summary>
    public static PlayerTickrateClCommand CreateSet(int value)
    {
        var cmd = CreatePackage<PlayerTickrateClCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
