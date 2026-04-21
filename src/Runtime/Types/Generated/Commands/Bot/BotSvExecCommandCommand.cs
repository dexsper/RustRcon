using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Executes a console command on a specific bot player by name or Steam ID; hidden from admin UI as it is intended for bot scripting only</summary>
/// <remarks>Full RCON name: <c>bot.sv_exec_command</c></remarks>
public sealed class BotSvExecCommandCommand : BaseCallCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bot.sv_exec_command";

    /// <summary>Creates a new <see cref="BotSvExecCommandCommand"/> command.</summary>
    public static BotSvExecCommandCommand Create()
    {
        var cmd = CreatePackage<BotSvExecCommandCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
