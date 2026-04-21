using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>All ammo drops from NPC loot will be multiplied by this</summary>
/// <remarks>Full RCON name: <c>server.npcammolootmultiplier</c></remarks>
public sealed class ServerNpcammolootmultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.npcammolootmultiplier";

    /// <summary>Reads the current value of <c>server.npcammolootmultiplier</c>.</summary>
    public static ServerNpcammolootmultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<ServerNpcammolootmultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.npcammolootmultiplier</c> to <paramref name="value"/>.</summary>
    public static ServerNpcammolootmultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerNpcammolootmultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
