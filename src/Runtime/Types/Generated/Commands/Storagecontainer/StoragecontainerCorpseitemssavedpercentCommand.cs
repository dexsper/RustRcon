using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Fraction of items preserved when a storage container spawns a death corpse; 0.5 = 50% of items survive the container death</summary>
/// <remarks>Full RCON name: <c>storagecontainer.corpseitemssavedpercent</c></remarks>
public sealed class StoragecontainerCorpseitemssavedpercentCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "storagecontainer.corpseitemssavedpercent";

    /// <summary>Reads the current value of <c>storagecontainer.corpseitemssavedpercent</c>.</summary>
    public static StoragecontainerCorpseitemssavedpercentCommand CreateGet()
    {
        var cmd = CreatePackage<StoragecontainerCorpseitemssavedpercentCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>storagecontainer.corpseitemssavedpercent</c> to <paramref name="value"/>.</summary>
    public static StoragecontainerCorpseitemssavedpercentCommand CreateSet(float value)
    {
        var cmd = CreatePackage<StoragecontainerCorpseitemssavedpercentCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
