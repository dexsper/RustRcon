using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Print a log message when a command block is executed</summary>
/// <remarks>Full RCON name: <c>commandblock.log_executions</c></remarks>
public sealed class CommandblockLogExecutionsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "commandblock.log_executions";

    /// <summary>Reads the current value of <c>commandblock.log_executions</c>.</summary>
    public static CommandblockLogExecutionsCommand CreateGet()
    {
        var cmd = CreatePackage<CommandblockLogExecutionsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>commandblock.log_executions</c> to <paramref name="value"/>.</summary>
    public static CommandblockLogExecutionsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<CommandblockLogExecutionsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
