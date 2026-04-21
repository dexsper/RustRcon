using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How many seconds until the crate is destroyed without any hack attempts</summary>
/// <remarks>Full RCON name: <c>hackablelockedcrate.decayseconds</c></remarks>
public sealed class HackablelockedcrateDecaysecondsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "hackablelockedcrate.decayseconds";

    /// <summary>Reads the current value of <c>hackablelockedcrate.decayseconds</c>.</summary>
    public static HackablelockedcrateDecaysecondsCommand CreateGet()
    {
        var cmd = CreatePackage<HackablelockedcrateDecaysecondsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>hackablelockedcrate.decayseconds</c> to <paramref name="value"/>.</summary>
    public static HackablelockedcrateDecaysecondsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<HackablelockedcrateDecaysecondsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
