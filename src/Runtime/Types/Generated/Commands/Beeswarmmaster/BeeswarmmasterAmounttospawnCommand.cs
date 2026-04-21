using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How many child swarms a master swarm will create</summary>
/// <remarks>Full RCON name: <c>beeswarmmaster.amounttospawn</c></remarks>
public sealed class BeeswarmmasterAmounttospawnCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "beeswarmmaster.amounttospawn";

    /// <summary>Reads the current value of <c>beeswarmmaster.amounttospawn</c>.</summary>
    public static BeeswarmmasterAmounttospawnCommand CreateGet()
    {
        var cmd = CreatePackage<BeeswarmmasterAmounttospawnCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>beeswarmmaster.amounttospawn</c> to <paramref name="value"/>.</summary>
    public static BeeswarmmasterAmounttospawnCommand CreateSet(int value)
    {
        var cmd = CreatePackage<BeeswarmmasterAmounttospawnCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
