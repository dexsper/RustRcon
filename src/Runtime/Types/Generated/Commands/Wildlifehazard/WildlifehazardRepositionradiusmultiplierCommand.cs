using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Global multiplier for the radius used when choosing a new reposition destination for a wildlife hazard</summary>
/// <remarks>Full RCON name: <c>wildlifehazard.repositionradiusmultiplier</c></remarks>
public sealed class WildlifehazardRepositionradiusmultiplierCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "wildlifehazard.repositionradiusmultiplier";

    /// <summary>Reads the current value of <c>wildlifehazard.repositionradiusmultiplier</c>.</summary>
    public static WildlifehazardRepositionradiusmultiplierCommand CreateGet()
    {
        var cmd = CreatePackage<WildlifehazardRepositionradiusmultiplierCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>wildlifehazard.repositionradiusmultiplier</c> to <paramref name="value"/>.</summary>
    public static WildlifehazardRepositionradiusmultiplierCommand CreateSet(float value)
    {
        var cmd = CreatePackage<WildlifehazardRepositionradiusmultiplierCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
