using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long we are not moving for before trigger the stuck event</summary>
/// <remarks>Full RCON name: <c>basenavigator.stucktriggerduration</c></remarks>
public sealed class BasenavigatorStucktriggerdurationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "basenavigator.stucktriggerduration";

    /// <summary>Reads the current value of <c>basenavigator.stucktriggerduration</c>.</summary>
    public static BasenavigatorStucktriggerdurationCommand CreateGet()
    {
        var cmd = CreatePackage<BasenavigatorStucktriggerdurationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>basenavigator.stucktriggerduration</c> to <paramref name="value"/>.</summary>
    public static BasenavigatorStucktriggerdurationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BasenavigatorStucktriggerdurationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
