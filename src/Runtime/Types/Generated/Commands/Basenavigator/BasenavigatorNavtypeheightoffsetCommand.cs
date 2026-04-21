using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>basenavigator.navtypeheightoffset</c>.</summary>
/// <remarks>Full RCON name: <c>basenavigator.navtypeheightoffset</c></remarks>
public sealed class BasenavigatorNavtypeheightoffsetCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "basenavigator.navtypeheightoffset";

    /// <summary>Reads the current value of <c>basenavigator.navtypeheightoffset</c>.</summary>
    public static BasenavigatorNavtypeheightoffsetCommand CreateGet()
    {
        var cmd = CreatePackage<BasenavigatorNavtypeheightoffsetCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>basenavigator.navtypeheightoffset</c> to <paramref name="value"/>.</summary>
    public static BasenavigatorNavtypeheightoffsetCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BasenavigatorNavtypeheightoffsetCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
