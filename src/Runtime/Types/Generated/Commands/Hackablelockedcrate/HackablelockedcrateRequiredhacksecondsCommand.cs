using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How many seconds for the crate to unlock</summary>
/// <remarks>Full RCON name: <c>hackablelockedcrate.requiredhackseconds</c></remarks>
public sealed class HackablelockedcrateRequiredhacksecondsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "hackablelockedcrate.requiredhackseconds";

    /// <summary>Reads the current value of <c>hackablelockedcrate.requiredhackseconds</c>.</summary>
    public static HackablelockedcrateRequiredhacksecondsCommand CreateGet()
    {
        var cmd = CreatePackage<HackablelockedcrateRequiredhacksecondsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>hackablelockedcrate.requiredhackseconds</c> to <paramref name="value"/>.</summary>
    public static HackablelockedcrateRequiredhacksecondsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<HackablelockedcrateRequiredhacksecondsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
