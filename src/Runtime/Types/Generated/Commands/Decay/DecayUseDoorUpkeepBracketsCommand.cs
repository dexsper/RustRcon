using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Should doors have their own upkeep brackets separate from building blocks</summary>
/// <remarks>Full RCON name: <c>decay.use_door_upkeep_brackets</c></remarks>
public sealed class DecayUseDoorUpkeepBracketsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.use_door_upkeep_brackets";

    /// <summary>Reads the current value of <c>decay.use_door_upkeep_brackets</c>.</summary>
    public static DecayUseDoorUpkeepBracketsCommand CreateGet()
    {
        var cmd = CreatePackage<DecayUseDoorUpkeepBracketsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.use_door_upkeep_brackets</c> to <paramref name="value"/>.</summary>
    public static DecayUseDoorUpkeepBracketsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<DecayUseDoorUpkeepBracketsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
