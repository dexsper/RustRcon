using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Sets the ducked/crouching model state on a specific bot by name or Steam ID; used to control bot posture in testing scenarios</summary>
/// <remarks>Full RCON name: <c>bot.crouch_server</c></remarks>
public sealed class BotCrouchServerCommand : BaseCallCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bot.crouch_server";

    /// <summary>Creates a new <see cref="BotCrouchServerCommand"/> command.</summary>
    public static BotCrouchServerCommand Create()
    {
        var cmd = CreatePackage<BotCrouchServerCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
