using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Maximum initial bet per round</summary>
/// <remarks>Full RCON name: <c>blackjackmachine.maxbet</c></remarks>
public sealed class BlackjackmachineMaxbetCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "blackjackmachine.maxbet";

    /// <summary>Reads the current value of <c>blackjackmachine.maxbet</c>.</summary>
    public static BlackjackmachineMaxbetCommand CreateGet()
    {
        var cmd = CreatePackage<BlackjackmachineMaxbetCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>blackjackmachine.maxbet</c> to <paramref name="value"/>.</summary>
    public static BlackjackmachineMaxbetCommand CreateSet(int value)
    {
        var cmd = CreatePackage<BlackjackmachineMaxbetCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
