using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Should we be zipping the demos before we upload them</summary>
/// <remarks>Full RCON name: <c>demo.zip_demos</c></remarks>
public sealed class DemoZipDemosCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "demo.zip_demos";

    /// <summary>Reads the current value of <c>demo.zip_demos</c>.</summary>
    public static DemoZipDemosCommand CreateGet()
    {
        var cmd = CreatePackage<DemoZipDemosCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>demo.zip_demos</c> to <paramref name="value"/>.</summary>
    public static DemoZipDemosCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<DemoZipDemosCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
