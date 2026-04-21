using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The Minimum point that the price can drop to (0.5 = 50% off)</summary>
/// <remarks>Full RCON name: <c>npcvendingmachine.minimumpricemultiplier</c></remarks>
public sealed class NpcvendingmachineMinimumpricemultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "npcvendingmachine.minimumpricemultiplier";

    /// <summary>Reads the current value of <c>npcvendingmachine.minimumpricemultiplier</c>.</summary>
    public static NpcvendingmachineMinimumpricemultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<NpcvendingmachineMinimumpricemultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>npcvendingmachine.minimumpricemultiplier</c> to <paramref name="value"/>.</summary>
    public static NpcvendingmachineMinimumpricemultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<NpcvendingmachineMinimumpricemultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
