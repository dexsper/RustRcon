using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When false, prevents the Bradley APC from spawning or respawning on the server</summary>
/// <remarks>Full RCON name: <c>bradley.enabled</c></remarks>
public sealed class BradleyEnabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "bradley.enabled";

    /// <summary>Reads the current value of <c>bradley.enabled</c>.</summary>
    public static BradleyEnabledCommand CreateGet()
    {
        var cmd = CreatePackage<BradleyEnabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>bradley.enabled</c> to <paramref name="value"/>.</summary>
    public static BradleyEnabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<BradleyEnabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
