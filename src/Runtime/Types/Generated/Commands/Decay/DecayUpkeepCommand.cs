using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Is upkeep enabled</summary>
/// <remarks>Full RCON name: <c>decay.upkeep</c></remarks>
public sealed class DecayUpkeepCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.upkeep";

    /// <summary>Reads the current value of <c>decay.upkeep</c>.</summary>
    public static DecayUpkeepCommand CreateGet()
    {
        var cmd = CreatePackage<DecayUpkeepCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.upkeep</c> to <paramref name="value"/>.</summary>
    public static DecayUpkeepCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<DecayUpkeepCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
