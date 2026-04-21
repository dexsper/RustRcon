using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How far we detect players from our inside/outside</summary>
/// <remarks>Full RCON name: <c>xmasdungeon.playerdetectrange</c></remarks>
public sealed class XmasdungeonPlayerdetectrangeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "xmasdungeon.playerdetectrange";

    /// <summary>Reads the current value of <c>xmasdungeon.playerdetectrange</c>.</summary>
    public static XmasdungeonPlayerdetectrangeCommand CreateGet()
    {
        var cmd = CreatePackage<XmasdungeonPlayerdetectrangeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>xmasdungeon.playerdetectrange</c> to <paramref name="value"/>.</summary>
    public static XmasdungeonPlayerdetectrangeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<XmasdungeonPlayerdetectrangeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
