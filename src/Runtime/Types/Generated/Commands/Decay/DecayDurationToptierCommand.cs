using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long should this building grade take to decay when not protected by upkeep, in hours</summary>
/// <remarks>Full RCON name: <c>decay.duration_toptier</c></remarks>
public sealed class DecayDurationToptierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.duration_toptier";

    /// <summary>Reads the current value of <c>decay.duration_toptier</c>.</summary>
    public static DecayDurationToptierCommand CreateGet()
    {
        var cmd = CreatePackage<DecayDurationToptierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.duration_toptier</c> to <paramref name="value"/>.</summary>
    public static DecayDurationToptierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayDurationToptierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
