using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>What discount surcharge should be applied to items when the server starts</summary>
/// <remarks>Full RCON name: <c>npcvendingmachine.startingpricemultiplier</c></remarks>
public sealed class NpcvendingmachineStartingpricemultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "npcvendingmachine.startingpricemultiplier";

    /// <summary>Reads the current value of <c>npcvendingmachine.startingpricemultiplier</c>.</summary>
    public static NpcvendingmachineStartingpricemultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<NpcvendingmachineStartingpricemultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>npcvendingmachine.startingpricemultiplier</c> to <paramref name="value"/>.</summary>
    public static NpcvendingmachineStartingpricemultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<NpcvendingmachineStartingpricemultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
