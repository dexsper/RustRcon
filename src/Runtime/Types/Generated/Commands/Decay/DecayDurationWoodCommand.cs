using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long should this building grade take to decay when not protected by upkeep, in hours</summary>
/// <remarks>Full RCON name: <c>decay.duration_wood</c></remarks>
public sealed class DecayDurationWoodCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.duration_wood";

    /// <summary>Reads the current value of <c>decay.duration_wood</c>.</summary>
    public static DecayDurationWoodCommand CreateGet()
    {
        var cmd = CreatePackage<DecayDurationWoodCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.duration_wood</c> to <paramref name="value"/>.</summary>
    public static DecayDurationWoodCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayDurationWoodCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
