using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, storage containers that die spawn a loot corpse containing their items; when false items are destroyed</summary>
/// <remarks>Full RCON name: <c>storagecontainer.dropcorpseondeath</c></remarks>
public sealed class StoragecontainerDropcorpseondeathCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "storagecontainer.dropcorpseondeath";

    /// <summary>Reads the current value of <c>storagecontainer.dropcorpseondeath</c>.</summary>
    public static StoragecontainerDropcorpseondeathCommand CreateGet()
    {
        var cmd = CreatePackage<StoragecontainerDropcorpseondeathCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>storagecontainer.dropcorpseondeath</c> to <paramref name="value"/>.</summary>
    public static StoragecontainerDropcorpseondeathCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<StoragecontainerDropcorpseondeathCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
