using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, logs decay tick details to the console including which entities took damage and how much</summary>
/// <remarks>Full RCON name: <c>decay.debug</c></remarks>
public sealed class DecayDebugCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.debug";

    /// <summary>Reads the current value of <c>decay.debug</c>.</summary>
    public static DecayDebugCommand CreateGet()
    {
        var cmd = CreatePackage<DecayDebugCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.debug</c> to <paramref name="value"/>.</summary>
    public static DecayDebugCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<DecayDebugCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
