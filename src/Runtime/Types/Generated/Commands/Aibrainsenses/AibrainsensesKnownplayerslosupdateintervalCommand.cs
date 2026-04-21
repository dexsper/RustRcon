using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Interval in seconds between line-of-sight update ticks for all NPC types tracking known player positions</summary>
/// <remarks>Full RCON name: <c>aibrainsenses.knownplayerslosupdateinterval</c></remarks>
public sealed class AibrainsensesKnownplayerslosupdateintervalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "aibrainsenses.knownplayerslosupdateinterval";

    /// <summary>Reads the current value of <c>aibrainsenses.knownplayerslosupdateinterval</c>.</summary>
    public static AibrainsensesKnownplayerslosupdateintervalCommand CreateGet()
    {
        var cmd = CreatePackage<AibrainsensesKnownplayerslosupdateintervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>aibrainsenses.knownplayerslosupdateinterval</c> to <paramref name="value"/>.</summary>
    public static AibrainsensesKnownplayerslosupdateintervalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AibrainsensesKnownplayerslosupdateintervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
