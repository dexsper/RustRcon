using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum distance in metres between party member spawn points when spawning a group together on wake-up</summary>
/// <remarks>Full RCON name: <c>party.maxpartyspawndistance</c></remarks>
public sealed class PartyMaxpartyspawndistanceCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "party.maxpartyspawndistance";

    /// <summary>Reads the current value of <c>party.maxpartyspawndistance</c>.</summary>
    public static PartyMaxpartyspawndistanceCommand CreateGet()
    {
        var cmd = CreatePackage<PartyMaxpartyspawndistanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>party.maxpartyspawndistance</c> to <paramref name="value"/>.</summary>
    public static PartyMaxpartyspawndistanceCommand CreateSet(int value)
    {
        var cmd = CreatePackage<PartyMaxpartyspawndistanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
