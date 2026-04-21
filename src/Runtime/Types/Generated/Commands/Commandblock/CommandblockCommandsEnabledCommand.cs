using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Can command blocks execute commands</summary>
/// <remarks>Full RCON name: <c>commandblock.commands_enabled</c></remarks>
public sealed class CommandblockCommandsEnabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "commandblock.commands_enabled";

    /// <summary>Reads the current value of <c>commandblock.commands_enabled</c>.</summary>
    public static CommandblockCommandsEnabledCommand CreateGet()
    {
        var cmd = CreatePackage<CommandblockCommandsEnabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>commandblock.commands_enabled</c> to <paramref name="value"/>.</summary>
    public static CommandblockCommandsEnabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<CommandblockCommandsEnabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
