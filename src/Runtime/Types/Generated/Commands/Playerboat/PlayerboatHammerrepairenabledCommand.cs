using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>playerboat.hammerrepairenabled</c>.</summary>
/// <remarks>Full RCON name: <c>playerboat.hammerrepairenabled</c></remarks>
public sealed class PlayerboatHammerrepairenabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.hammerrepairenabled";

    /// <summary>Reads the current value of <c>playerboat.hammerrepairenabled</c>.</summary>
    public static PlayerboatHammerrepairenabledCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerboatHammerrepairenabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>playerboat.hammerrepairenabled</c> to <paramref name="value"/>.</summary>
    public static PlayerboatHammerrepairenabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PlayerboatHammerrepairenabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
