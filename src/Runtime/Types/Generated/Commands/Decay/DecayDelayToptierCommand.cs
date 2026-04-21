using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long should this building grade decay be delayed when not protected by upkeep, in hours</summary>
/// <remarks>Full RCON name: <c>decay.delay_toptier</c></remarks>
public sealed class DecayDelayToptierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.delay_toptier";

    /// <summary>Reads the current value of <c>decay.delay_toptier</c>.</summary>
    public static DecayDelayToptierCommand CreateGet()
    {
        var cmd = CreatePackage<DecayDelayToptierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.delay_toptier</c> to <paramref name="value"/>.</summary>
    public static DecayDelayToptierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayDelayToptierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
