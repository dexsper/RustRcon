using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How far away fire has to be to set the swarm on fire</summary>
/// <remarks>Full RCON name: <c>beeswarmai.flamesettingdistance</c></remarks>
public sealed class BeeswarmaiFlamesettingdistanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "beeswarmai.flamesettingdistance";

    /// <summary>Reads the current value of <c>beeswarmai.flamesettingdistance</c>.</summary>
    public static BeeswarmaiFlamesettingdistanceCommand CreateGet()
    {
        var cmd = CreatePackage<BeeswarmaiFlamesettingdistanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>beeswarmai.flamesettingdistance</c> to <paramref name="value"/>.</summary>
    public static BeeswarmaiFlamesettingdistanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BeeswarmaiFlamesettingdistanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
