using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Interval in seconds between full AI brain senses update ticks; controls how frequently NPCs refresh their awareness of surroundings</summary>
/// <remarks>Full RCON name: <c>aibrainsenses.updateinterval</c></remarks>
public sealed class AibrainsensesUpdateintervalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "aibrainsenses.updateinterval";

    /// <summary>Reads the current value of <c>aibrainsenses.updateinterval</c>.</summary>
    public static AibrainsensesUpdateintervalCommand CreateGet()
    {
        var cmd = CreatePackage<AibrainsensesUpdateintervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>aibrainsenses.updateinterval</c> to <paramref name="value"/>.</summary>
    public static AibrainsensesUpdateintervalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AibrainsensesUpdateintervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
