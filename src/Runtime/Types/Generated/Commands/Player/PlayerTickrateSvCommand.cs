using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>player.tickrate_sv</c>.</summary>
/// <remarks>Full RCON name: <c>player.tickrate_sv</c></remarks>
public sealed class PlayerTickrateSvCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "player.tickrate_sv";

    /// <summary>Reads the current value of <c>player.tickrate_sv</c>.</summary>
    public static PlayerTickrateSvCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerTickrateSvCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>player.tickrate_sv</c> to <paramref name="value"/>.</summary>
    public static PlayerTickrateSvCommand CreateSet(int value)
    {
        var cmd = CreatePackage<PlayerTickrateSvCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
