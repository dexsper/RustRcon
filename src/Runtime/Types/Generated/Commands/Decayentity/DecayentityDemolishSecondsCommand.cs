using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Time window in seconds after placement during which a player can demolish their own building block; default 600s (10 minutes)</summary>
/// <remarks>Full RCON name: <c>decayentity.demolish_seconds</c></remarks>
public sealed class DecayentityDemolishSecondsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decayentity.demolish_seconds";

    /// <summary>Reads the current value of <c>decayentity.demolish_seconds</c>.</summary>
    public static DecayentityDemolishSecondsCommand CreateGet()
    {
        var cmd = CreatePackage<DecayentityDemolishSecondsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decayentity.demolish_seconds</c> to <paramref name="value"/>.</summary>
    public static DecayentityDemolishSecondsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<DecayentityDemolishSecondsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
