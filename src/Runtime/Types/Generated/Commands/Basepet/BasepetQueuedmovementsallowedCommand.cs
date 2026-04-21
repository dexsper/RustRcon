using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>basepet.queuedmovementsallowed</c>.</summary>
/// <remarks>Full RCON name: <c>basepet.queuedmovementsallowed</c></remarks>
public sealed class BasepetQueuedmovementsallowedCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "basepet.queuedmovementsallowed";

    /// <summary>Reads the current value of <c>basepet.queuedmovementsallowed</c>.</summary>
    public static BasepetQueuedmovementsallowedCommand CreateGet()
    {
        var cmd = CreatePackage<BasepetQueuedmovementsallowedCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>basepet.queuedmovementsallowed</c> to <paramref name="value"/>.</summary>
    public static BasepetQueuedmovementsallowedCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<BasepetQueuedmovementsallowedCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
