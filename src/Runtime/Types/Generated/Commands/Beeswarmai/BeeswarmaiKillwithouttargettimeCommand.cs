using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long a swarm will stick around without a target</summary>
/// <remarks>Full RCON name: <c>beeswarmai.killwithouttargettime</c></remarks>
public sealed class BeeswarmaiKillwithouttargettimeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "beeswarmai.killwithouttargettime";

    /// <summary>Reads the current value of <c>beeswarmai.killwithouttargettime</c>.</summary>
    public static BeeswarmaiKillwithouttargettimeCommand CreateGet()
    {
        var cmd = CreatePackage<BeeswarmaiKillwithouttargettimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>beeswarmai.killwithouttargettime</c> to <paramref name="value"/>.</summary>
    public static BeeswarmaiKillwithouttargettimeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BeeswarmaiKillwithouttargettimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
