using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>baseboat.seconds_until_shore_drift</c>.</summary>
/// <remarks>Full RCON name: <c>baseboat.seconds_until_shore_drift</c></remarks>
public sealed class BaseboatSecondsUntilShoreDriftCommand : BaseCallCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "baseboat.seconds_until_shore_drift";

    /// <summary>Creates a new <see cref="BaseboatSecondsUntilShoreDriftCommand"/> command.</summary>
    public static BaseboatSecondsUntilShoreDriftCommand Create()
    {
        var cmd = CreatePackage<BaseboatSecondsUntilShoreDriftCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
