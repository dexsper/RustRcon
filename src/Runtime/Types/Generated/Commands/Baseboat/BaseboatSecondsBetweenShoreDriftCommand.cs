using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>baseboat.seconds_between_shore_drift</c>.</summary>
/// <remarks>Full RCON name: <c>baseboat.seconds_between_shore_drift</c></remarks>
public sealed class BaseboatSecondsBetweenShoreDriftCommand : BaseCallCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "baseboat.seconds_between_shore_drift";

    /// <summary>Creates a new <see cref="BaseboatSecondsBetweenShoreDriftCommand"/> command.</summary>
    public static BaseboatSecondsBetweenShoreDriftCommand Create()
    {
        var cmd = CreatePackage<BaseboatSecondsBetweenShoreDriftCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
