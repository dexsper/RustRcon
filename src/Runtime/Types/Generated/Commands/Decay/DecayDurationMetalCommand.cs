using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long should this building grade take to decay when not protected by upkeep, in hours</summary>
/// <remarks>Full RCON name: <c>decay.duration_metal</c></remarks>
public sealed class DecayDurationMetalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.duration_metal";

    /// <summary>Reads the current value of <c>decay.duration_metal</c>.</summary>
    public static DecayDurationMetalCommand CreateGet()
    {
        var cmd = CreatePackage<DecayDurationMetalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.duration_metal</c> to <paramref name="value"/>.</summary>
    public static DecayDurationMetalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayDurationMetalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
