using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Interval in seconds between line-of-sight update ticks for human-type NPCs tracking known player positions</summary>
/// <remarks>Full RCON name: <c>aibrainsenses.humanknownplayerslosupdateinterval</c></remarks>
public sealed class AibrainsensesHumanknownplayerslosupdateintervalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "aibrainsenses.humanknownplayerslosupdateinterval";

    /// <summary>Reads the current value of <c>aibrainsenses.humanknownplayerslosupdateinterval</c>.</summary>
    public static AibrainsensesHumanknownplayerslosupdateintervalCommand CreateGet()
    {
        var cmd = CreatePackage<AibrainsensesHumanknownplayerslosupdateintervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>aibrainsenses.humanknownplayerslosupdateinterval</c> to <paramref name="value"/>.</summary>
    public static AibrainsensesHumanknownplayerslosupdateintervalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AibrainsensesHumanknownplayerslosupdateintervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
