using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long should this building grade take to decay when not protected by upkeep, in hours</summary>
/// <remarks>Full RCON name: <c>decay.duration_stone</c></remarks>
public sealed class DecayDurationStoneCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.duration_stone";

    /// <summary>Reads the current value of <c>decay.duration_stone</c>.</summary>
    public static DecayDurationStoneCommand CreateGet()
    {
        var cmd = CreatePackage<DecayDurationStoneCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.duration_stone</c> to <paramref name="value"/>.</summary>
    public static DecayDurationStoneCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayDurationStoneCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
