using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long should this building grade decay be delayed when not protected by upkeep, in hours</summary>
/// <remarks>Full RCON name: <c>decay.delay_stone</c></remarks>
public sealed class DecayDelayStoneCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.delay_stone";

    /// <summary>Reads the current value of <c>decay.delay_stone</c>.</summary>
    public static DecayDelayStoneCommand CreateGet()
    {
        var cmd = CreatePackage<DecayDelayStoneCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.delay_stone</c> to <paramref name="value"/>.</summary>
    public static DecayDelayStoneCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayDelayStoneCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
