using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum number of attempts the server makes to find a valid spawn point when spawning a party together; higher values increase the chance of grouping</summary>
/// <remarks>Full RCON name: <c>party.maxpartyspawnattempts</c></remarks>
public sealed class PartyMaxpartyspawnattemptsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "party.maxpartyspawnattempts";

    /// <summary>Reads the current value of <c>party.maxpartyspawnattempts</c>.</summary>
    public static PartyMaxpartyspawnattemptsCommand CreateGet()
    {
        var cmd = CreatePackage<PartyMaxpartyspawnattemptsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>party.maxpartyspawnattempts</c> to <paramref name="value"/>.</summary>
    public static PartyMaxpartyspawnattemptsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<PartyMaxpartyspawnattemptsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
