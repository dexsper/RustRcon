using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, players can directionally drop items by looking in the desired direction; disable to revert to gravity-only drops</summary>
/// <remarks>Full RCON name: <c>playerinventory.directionaldropenabled</c></remarks>
public sealed class PlayerinventoryDirectionaldropenabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerinventory.directionaldropenabled";

    /// <summary>Reads the current value of <c>playerinventory.directionaldropenabled</c>.</summary>
    public static PlayerinventoryDirectionaldropenabledCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerinventoryDirectionaldropenabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>playerinventory.directionaldropenabled</c> to <paramref name="value"/>.</summary>
    public static PlayerinventoryDirectionaldropenabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PlayerinventoryDirectionaldropenabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
