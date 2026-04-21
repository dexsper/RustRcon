using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long should this building grade decay be delayed when not protected by upkeep, in hours</summary>
/// <remarks>Full RCON name: <c>decay.delay_metal</c></remarks>
public sealed class DecayDelayMetalCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.delay_metal";

    /// <summary>Reads the current value of <c>decay.delay_metal</c>.</summary>
    public static DecayDelayMetalCommand CreateGet()
    {
        var cmd = CreatePackage<DecayDelayMetalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.delay_metal</c> to <paramref name="value"/>.</summary>
    public static DecayDelayMetalCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayDelayMetalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
