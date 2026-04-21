using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>When enabled, deployables on boats send immediate network updates when orphaned during edit mode to prevent looping sounds from being killed</summary>
/// <remarks>Full RCON name: <c>playerboat.orphansendimmediate</c></remarks>
public sealed class PlayerboatOrphansendimmediateCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "playerboat.orphansendimmediate";

    /// <summary>Reads the current value of <c>playerboat.orphansendimmediate</c>.</summary>
    public static PlayerboatOrphansendimmediateCommand CreateGet()
    {
        var cmd = CreatePackage<PlayerboatOrphansendimmediateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>playerboat.orphansendimmediate</c> to <paramref name="value"/>.</summary>
    public static PlayerboatOrphansendimmediateCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<PlayerboatOrphansendimmediateCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
