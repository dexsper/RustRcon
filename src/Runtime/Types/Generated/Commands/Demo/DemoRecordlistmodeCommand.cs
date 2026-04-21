using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Controls the behavior of recordlist, 0=whitelist, 1=blacklist</summary>
/// <remarks>Full RCON name: <c>demo.recordlistmode</c></remarks>
public sealed class DemoRecordlistmodeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "demo.recordlistmode";

    /// <summary>Reads the current value of <c>demo.recordlistmode</c>.</summary>
    public static DemoRecordlistmodeCommand CreateGet()
    {
        var cmd = CreatePackage<DemoRecordlistmodeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>demo.recordlistmode</c> to <paramref name="value"/>.</summary>
    public static DemoRecordlistmodeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<DemoRecordlistmodeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
