using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The maximum point that a price can increase to (2 = 200%)</summary>
/// <remarks>Full RCON name: <c>npcvendingmachine.maximumpricemultiplier</c></remarks>
public sealed class NpcvendingmachineMaximumpricemultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "npcvendingmachine.maximumpricemultiplier";

    /// <summary>Reads the current value of <c>npcvendingmachine.maximumpricemultiplier</c>.</summary>
    public static NpcvendingmachineMaximumpricemultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<NpcvendingmachineMaximumpricemultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>npcvendingmachine.maximumpricemultiplier</c> to <paramref name="value"/>.</summary>
    public static NpcvendingmachineMaximumpricemultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<NpcvendingmachineMaximumpricemultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
