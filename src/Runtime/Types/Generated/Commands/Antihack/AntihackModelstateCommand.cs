using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.modelstate</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.modelstate</c></remarks>
public sealed class AntihackModelstateCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.modelstate";

    /// <summary>Reads the current value of <c>antihack.modelstate</c>.</summary>
    public static AntihackModelstateCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackModelstateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.modelstate</c> to <paramref name="value"/>.</summary>
    public static AntihackModelstateCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackModelstateCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
