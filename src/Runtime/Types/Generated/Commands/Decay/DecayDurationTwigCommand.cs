using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long should this building grade take to decay when not protected by upkeep, in hours</summary>
/// <remarks>Full RCON name: <c>decay.duration_twig</c></remarks>
public sealed class DecayDurationTwigCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.duration_twig";

    /// <summary>Reads the current value of <c>decay.duration_twig</c>.</summary>
    public static DecayDurationTwigCommand CreateGet()
    {
        var cmd = CreatePackage<DecayDurationTwigCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.duration_twig</c> to <paramref name="value"/>.</summary>
    public static DecayDurationTwigCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayDurationTwigCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
