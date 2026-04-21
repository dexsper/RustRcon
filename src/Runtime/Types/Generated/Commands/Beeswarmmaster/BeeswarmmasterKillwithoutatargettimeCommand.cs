using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long a master swarm will stick around without a target</summary>
/// <remarks>Full RCON name: <c>beeswarmmaster.killwithoutatargettime</c></remarks>
public sealed class BeeswarmmasterKillwithoutatargettimeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "beeswarmmaster.killwithoutatargettime";

    /// <summary>Reads the current value of <c>beeswarmmaster.killwithoutatargettime</c>.</summary>
    public static BeeswarmmasterKillwithoutatargettimeCommand CreateGet()
    {
        var cmd = CreatePackage<BeeswarmmasterKillwithoutatargettimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>beeswarmmaster.killwithoutatargettime</c> to <paramref name="value"/>.</summary>
    public static BeeswarmmasterKillwithoutatargettimeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BeeswarmmasterKillwithoutatargettimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
