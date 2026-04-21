using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>The max step-up height difference for pet base navigation</summary>
/// <remarks>Full RCON name: <c>basenavigator.maxstepupdistance</c></remarks>
public sealed class BasenavigatorMaxstepupdistanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "basenavigator.maxstepupdistance";

    /// <summary>Reads the current value of <c>basenavigator.maxstepupdistance</c>.</summary>
    public static BasenavigatorMaxstepupdistanceCommand CreateGet()
    {
        var cmd = CreatePackage<BasenavigatorMaxstepupdistanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>basenavigator.maxstepupdistance</c> to <paramref name="value"/>.</summary>
    public static BasenavigatorMaxstepupdistanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BasenavigatorMaxstepupdistanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
