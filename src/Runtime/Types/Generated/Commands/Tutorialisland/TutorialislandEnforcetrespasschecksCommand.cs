using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>tutorialisland.enforcetrespasschecks</c>.</summary>
/// <remarks>Full RCON name: <c>tutorialisland.enforcetrespasschecks</c></remarks>
public sealed class TutorialislandEnforcetrespasschecksCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "tutorialisland.enforcetrespasschecks";

    /// <summary>Reads the current value of <c>tutorialisland.enforcetrespasschecks</c>.</summary>
    public static TutorialislandEnforcetrespasschecksCommand CreateGet()
    {
        var cmd = CreatePackage<TutorialislandEnforcetrespasschecksCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>tutorialisland.enforcetrespasschecks</c> to <paramref name="value"/>.</summary>
    public static TutorialislandEnforcetrespasschecksCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<TutorialislandEnforcetrespasschecksCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
