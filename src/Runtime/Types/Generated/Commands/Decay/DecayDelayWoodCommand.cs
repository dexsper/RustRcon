using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long should this building grade decay be delayed when not protected by upkeep, in hours</summary>
/// <remarks>Full RCON name: <c>decay.delay_wood</c></remarks>
public sealed class DecayDelayWoodCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.delay_wood";

    /// <summary>Reads the current value of <c>decay.delay_wood</c>.</summary>
    public static DecayDelayWoodCommand CreateGet()
    {
        var cmd = CreatePackage<DecayDelayWoodCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.delay_wood</c> to <paramref name="value"/>.</summary>
    public static DecayDelayWoodCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayDelayWoodCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
