using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Maximum file size in megabytes before a demo recording is automatically split; prevents individual demo files from becoming unmanageably large</summary>
/// <remarks>Full RCON name: <c>demo.splitmegabytes</c></remarks>
public sealed class DemoSplitmegabytesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "demo.splitmegabytes";

    /// <summary>Reads the current value of <c>demo.splitmegabytes</c>.</summary>
    public static DemoSplitmegabytesCommand CreateGet()
    {
        var cmd = CreatePackage<DemoSplitmegabytesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>demo.splitmegabytes</c> to <paramref name="value"/>.</summary>
    public static DemoSplitmegabytesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DemoSplitmegabytesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
