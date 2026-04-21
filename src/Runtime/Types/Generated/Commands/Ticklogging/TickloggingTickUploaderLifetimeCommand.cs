using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>ticklogging.tick_uploader_lifetime</c>.</summary>
/// <remarks>Full RCON name: <c>ticklogging.tick_uploader_lifetime</c></remarks>
public sealed class TickloggingTickUploaderLifetimeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ticklogging.tick_uploader_lifetime";

    /// <summary>Reads the current value of <c>ticklogging.tick_uploader_lifetime</c>.</summary>
    public static TickloggingTickUploaderLifetimeCommand CreateGet()
    {
        var cmd = CreatePackage<TickloggingTickUploaderLifetimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ticklogging.tick_uploader_lifetime</c> to <paramref name="value"/>.</summary>
    public static TickloggingTickUploaderLifetimeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<TickloggingTickUploaderLifetimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
