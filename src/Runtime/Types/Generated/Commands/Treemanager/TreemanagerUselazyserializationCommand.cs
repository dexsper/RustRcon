using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Instead of reserializing grid cell on every tree add/removal(which can cost 0.25ms on 4.5k world), defer it to the streaming update. This reduces amount of times we need to serialize the tree list, but causes the player queue to take longer to process, as that's where evaluation happens.</summary>
/// <remarks>Full RCON name: <c>treemanager.uselazyserialization</c></remarks>
public sealed class TreemanagerUselazyserializationCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "treemanager.uselazyserialization";

    /// <summary>Reads the current value of <c>treemanager.uselazyserialization</c>.</summary>
    public static TreemanagerUselazyserializationCommand CreateGet()
    {
        var cmd = CreatePackage<TreemanagerUselazyserializationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>treemanager.uselazyserialization</c> to <paramref name="value"/>.</summary>
    public static TreemanagerUselazyserializationCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<TreemanagerUselazyserializationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
