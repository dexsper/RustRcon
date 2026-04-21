using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Multiplier applied to all decay damage per tick; 1.0 = normal, 2.0 = double decay rate, 0.0 = no decay</summary>
/// <remarks>Full RCON name: <c>decay.scale</c></remarks>
public sealed class DecayScaleCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.scale";

    /// <summary>Reads the current value of <c>decay.scale</c>.</summary>
    public static DecayScaleCommand CreateGet()
    {
        var cmd = CreatePackage<DecayScaleCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.scale</c> to <paramref name="value"/>.</summary>
    public static DecayScaleCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayScaleCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
