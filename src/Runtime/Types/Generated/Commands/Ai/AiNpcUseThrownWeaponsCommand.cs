using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If npc_use_thrown_weapons is true, npcs will throw grenades, etc. This is an experimental feature. (default: true)</summary>
/// <remarks>Full RCON name: <c>ai.npc_use_thrown_weapons</c></remarks>
public sealed class AiNpcUseThrownWeaponsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.npc_use_thrown_weapons";

    /// <summary>Reads the current value of <c>ai.npc_use_thrown_weapons</c>.</summary>
    public static AiNpcUseThrownWeaponsCommand CreateGet()
    {
        var cmd = CreatePackage<AiNpcUseThrownWeaponsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.npc_use_thrown_weapons</c> to <paramref name="value"/>.</summary>
    public static AiNpcUseThrownWeaponsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiNpcUseThrownWeaponsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
