using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>When set to a value above 0 everything will decay with this duration</summary>
/// <remarks>Full RCON name: <c>decay.duration_override</c></remarks>
public sealed class DecayDurationOverrideCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.duration_override";

    /// <summary>Reads the current value of <c>decay.duration_override</c>.</summary>
    public static DecayDurationOverrideCommand CreateGet()
    {
        var cmd = CreatePackage<DecayDurationOverrideCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.duration_override</c> to <paramref name="value"/>.</summary>
    public static DecayDurationOverrideCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayDurationOverrideCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
