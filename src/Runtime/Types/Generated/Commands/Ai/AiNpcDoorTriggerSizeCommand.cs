using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>npc_door_trigger_size defines the size of the trigger box on doors that opens the door as npcs walk close to it (default: 1.5)</summary>
/// <remarks>Full RCON name: <c>ai.npc_door_trigger_size</c></remarks>
public sealed class AiNpcDoorTriggerSizeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_door_trigger_size";

    /// <summary>Reads the current value of <c>ai.npc_door_trigger_size</c>.</summary>
    public static AiNpcDoorTriggerSizeCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcDoorTriggerSizeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_door_trigger_size</c> to <paramref name="value"/>.</summary>
    public static AiNpcDoorTriggerSizeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiNpcDoorTriggerSizeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
