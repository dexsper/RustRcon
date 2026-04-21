using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long should this building grade decay be delayed when not protected by upkeep, in hours</summary>
/// <remarks>Full RCON name: <c>decay.delay_twig</c></remarks>
public sealed class DecayDelayTwigCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.delay_twig";

    /// <summary>Reads the current value of <c>decay.delay_twig</c>.</summary>
    public static DecayDelayTwigCommand CreateGet()
    {
        var cmd = CreatePackage<DecayDelayTwigCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.delay_twig</c> to <paramref name="value"/>.</summary>
    public static DecayDelayTwigCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayDelayTwigCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
