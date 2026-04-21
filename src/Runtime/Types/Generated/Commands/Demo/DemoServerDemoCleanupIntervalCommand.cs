using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How many minutes between cleaning up demos from the disk</summary>
/// <remarks>Full RCON name: <c>demo.server_demo_cleanup_interval</c></remarks>
public sealed class DemoServerDemoCleanupIntervalCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "demo.server_demo_cleanup_interval";

    /// <summary>Reads the current value of <c>demo.server_demo_cleanup_interval</c>.</summary>
    public static DemoServerDemoCleanupIntervalCommand CreateGet()
    {
        var cmd = CreatePackage<DemoServerDemoCleanupIntervalCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>demo.server_demo_cleanup_interval</c> to <paramref name="value"/>.</summary>
    public static DemoServerDemoCleanupIntervalCommand CreateSet(int value)
    {
        var cmd = CreatePackage<DemoServerDemoCleanupIntervalCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
