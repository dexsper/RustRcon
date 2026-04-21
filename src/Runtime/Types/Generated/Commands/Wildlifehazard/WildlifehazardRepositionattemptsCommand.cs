using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum number of position candidates sampled when a wildlife hazard searches for a valid reposition destination</summary>
/// <remarks>Full RCON name: <c>wildlifehazard.repositionattempts</c></remarks>
public sealed class WildlifehazardRepositionattemptsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "wildlifehazard.repositionattempts";

    /// <summary>Reads the current value of <c>wildlifehazard.repositionattempts</c>.</summary>
    public static WildlifehazardRepositionattemptsCommand CreateGet()
    {
        var cmd = CreatePackage<WildlifehazardRepositionattemptsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>wildlifehazard.repositionattempts</c> to <paramref name="value"/>.</summary>
    public static WildlifehazardRepositionattemptsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<WildlifehazardRepositionattemptsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
