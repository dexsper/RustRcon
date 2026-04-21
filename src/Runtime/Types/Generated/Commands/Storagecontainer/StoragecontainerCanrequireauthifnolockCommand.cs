using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, storage containers without a lock can still require tool cupboard auth to access; default false</summary>
/// <remarks>Full RCON name: <c>storagecontainer.canrequireauthifnolock</c></remarks>
public sealed class StoragecontainerCanrequireauthifnolockCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "storagecontainer.canrequireauthifnolock";

    /// <summary>Reads the current value of <c>storagecontainer.canrequireauthifnolock</c>.</summary>
    public static StoragecontainerCanrequireauthifnolockCommand CreateGet()
    {
        var cmd = CreatePackage<StoragecontainerCanrequireauthifnolockCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>storagecontainer.canrequireauthifnolock</c> to <paramref name="value"/>.</summary>
    public static StoragecontainerCanrequireauthifnolockCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<StoragecontainerCanrequireauthifnolockCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
