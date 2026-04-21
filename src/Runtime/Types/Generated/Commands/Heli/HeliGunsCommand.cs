using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of gun hardpoints active on the patrol helicopter; set to 0 to disable its guns without despawning it</summary>
/// <remarks>Full RCON name: <c>heli.guns</c></remarks>
public sealed class HeliGunsCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "heli.guns";

    /// <summary>Reads the current value of <c>heli.guns</c>.</summary>
    public static HeliGunsCommand CreateGet()
    {
        var cmd = CreatePackage<HeliGunsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>heli.guns</c> to <paramref name="value"/>.</summary>
    public static HeliGunsCommand CreateSet(int value)
    {
        var cmd = CreatePackage<HeliGunsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
