using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of spawn attempts made per player when trying to place Christmas gifts during refill; higher values increase fill reliability in cluttered areas</summary>
/// <remarks>Full RCON name: <c>xmas.spawnattempts</c></remarks>
public sealed class XmasSpawnattemptsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "xmas.spawnattempts";

    /// <summary>Reads the current value of <c>xmas.spawnattempts</c>.</summary>
    public static XmasSpawnattemptsCommand CreateGet()
    {
        var cmd = CreatePackage<XmasSpawnattemptsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>xmas.spawnattempts</c> to <paramref name="value"/>.</summary>
    public static XmasSpawnattemptsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<XmasSpawnattemptsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
