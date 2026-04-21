using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How much disk space full server demos can take before we start to delete them</summary>
/// <remarks>Full RCON name: <c>demo.server_demo_disk_space_gb</c></remarks>
public sealed class DemoServerDemoDiskSpaceGbCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "demo.server_demo_disk_space_gb";

    /// <summary>Reads the current value of <c>demo.server_demo_disk_space_gb</c>.</summary>
    public static DemoServerDemoDiskSpaceGbCommand CreateGet()
    {
        var cmd = CreatePackage<DemoServerDemoDiskSpaceGbCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>demo.server_demo_disk_space_gb</c> to <paramref name="value"/>.</summary>
    public static DemoServerDemoDiskSpaceGbCommand CreateSet(int value)
    {
        var cmd = CreatePackage<DemoServerDemoDiskSpaceGbCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
