using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If enabled, commands from command blocks will run using the last player who set them, allowing for a wider range of commands to be used</summary>
/// <remarks>Full RCON name: <c>commandblock.use_player</c></remarks>
public sealed class CommandblockUsePlayerCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "commandblock.use_player";

    /// <summary>Reads the current value of <c>commandblock.use_player</c>.</summary>
    public static CommandblockUsePlayerCommand CreateGet()
    {
        var cmd = CreatePackage<CommandblockUsePlayerCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>commandblock.use_player</c> to <paramref name="value"/>.</summary>
    public static CommandblockUsePlayerCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<CommandblockUsePlayerCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
