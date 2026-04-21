using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>basenavigator.navtypedistance</c>.</summary>
/// <remarks>Full RCON name: <c>basenavigator.navtypedistance</c></remarks>
public sealed class BasenavigatorNavtypedistanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "basenavigator.navtypedistance";

    /// <summary>Reads the current value of <c>basenavigator.navtypedistance</c>.</summary>
    public static BasenavigatorNavtypedistanceCommand CreateGet()
    {
        var cmd = CreatePackage<BasenavigatorNavtypedistanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>basenavigator.navtypedistance</c> to <paramref name="value"/>.</summary>
    public static BasenavigatorNavtypedistanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BasenavigatorNavtypedistanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
