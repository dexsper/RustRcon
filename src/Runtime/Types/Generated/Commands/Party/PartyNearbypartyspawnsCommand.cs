using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, party members respawn near each other rather than at random map locations when joining a server together</summary>
/// <remarks>Full RCON name: <c>party.nearbypartyspawns</c></remarks>
public sealed class PartyNearbypartyspawnsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "party.nearbypartyspawns";

    /// <summary>Reads the current value of <c>party.nearbypartyspawns</c>.</summary>
    public static PartyNearbypartyspawnsCommand CreateGet()
    {
        var cmd = CreatePackage<PartyNearbypartyspawnsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>party.nearbypartyspawns</c> to <paramref name="value"/>.</summary>
    public static PartyNearbypartyspawnsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PartyNearbypartyspawnsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
