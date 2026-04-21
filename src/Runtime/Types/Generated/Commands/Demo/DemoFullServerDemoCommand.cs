using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, the server records a full demo of all gameplay to disk; these can be uploaded or kept locally for replay and anti-cheat review</summary>
/// <remarks>Full RCON name: <c>demo.full_server_demo</c></remarks>
public sealed class DemoFullServerDemoCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "demo.full_server_demo";

    /// <summary>Reads the current value of <c>demo.full_server_demo</c>.</summary>
    public static DemoFullServerDemoCommand CreateGet()
    {
        var cmd = CreatePackage<DemoFullServerDemoCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>demo.full_server_demo</c> to <paramref name="value"/>.</summary>
    public static DemoFullServerDemoCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<DemoFullServerDemoCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
