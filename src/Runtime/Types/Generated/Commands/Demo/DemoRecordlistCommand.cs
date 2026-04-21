using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Comma-separated list of player Steam IDs whose demos are automatically recorded on the server; empty means no targeted recording</summary>
/// <remarks>Full RCON name: <c>demo.recordlist</c></remarks>
public sealed class DemoRecordlistCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "demo.recordlist";

    /// <summary>Reads the current value of <c>demo.recordlist</c>.</summary>
    public static DemoRecordlistCommand CreateGet()
    {
        var cmd = CreatePackage<DemoRecordlistCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>demo.recordlist</c> to <paramref name="value"/>.</summary>
    public static DemoRecordlistCommand CreateSet(string value)
    {
        var cmd = CreatePackage<DemoRecordlistCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
