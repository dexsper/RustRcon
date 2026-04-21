using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Directory to save full server demos</summary>
/// <remarks>Full RCON name: <c>demo.server_demo_directory</c></remarks>
public sealed class DemoServerDemoDirectoryCommand : BaseConVarCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "demo.server_demo_directory";

    /// <summary>Reads the current value of <c>demo.server_demo_directory</c>.</summary>
    public static DemoServerDemoDirectoryCommand CreateGet()
    {
        var cmd = CreatePackage<DemoServerDemoDirectoryCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>demo.server_demo_directory</c> to <paramref name="value"/>.</summary>
    public static DemoServerDemoDirectoryCommand CreateSet(string value)
    {
        var cmd = CreatePackage<DemoServerDemoDirectoryCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
