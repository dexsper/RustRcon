using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>When set to a value above 0 everything will decay with this delay</summary>
/// <remarks>Full RCON name: <c>decay.delay_override</c></remarks>
public sealed class DecayDelayOverrideCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.delay_override";

    /// <summary>Reads the current value of <c>decay.delay_override</c>.</summary>
    public static DecayDelayOverrideCommand CreateGet()
    {
        var cmd = CreatePackage<DecayDelayOverrideCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.delay_override</c> to <paramref name="value"/>.</summary>
    public static DecayDelayOverrideCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayDelayOverrideCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
