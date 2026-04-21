using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>legacyshelter.max_shelters</c>.</summary>
/// <remarks>Full RCON name: <c>legacyshelter.max_shelters</c></remarks>
public sealed class LegacyshelterMaxSheltersCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "legacyshelter.max_shelters";

    /// <summary>Reads the current value of <c>legacyshelter.max_shelters</c>.</summary>
    public static LegacyshelterMaxSheltersCommand CreateGet()
    {
        var cmd = CreatePackage<LegacyshelterMaxSheltersCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>legacyshelter.max_shelters</c> to <paramref name="value"/>.</summary>
    public static LegacyshelterMaxSheltersCommand CreateSet(int value)
    {
        var cmd = CreatePackage<LegacyshelterMaxSheltersCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
