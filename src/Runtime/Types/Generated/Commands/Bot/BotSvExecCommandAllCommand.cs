using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Executes a console command on every bot player currently on the server; hidden from admin UI</summary>
/// <remarks>Full RCON name: <c>bot.sv_exec_command_all</c></remarks>
public sealed class BotSvExecCommandAllCommand : BaseCallCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bot.sv_exec_command_all";

    /// <summary>Creates a new <see cref="BotSvExecCommandAllCommand"/> command.</summary>
    public static BotSvExecCommandAllCommand Create()
    {
        var cmd = CreatePackage<BotSvExecCommandAllCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
