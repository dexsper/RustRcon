using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Stops the active server-side demo recording for the specified player and finalises the demo file</summary>
/// <remarks>Full RCON name: <c>demo.stop</c></remarks>
public sealed class DemoStopCommand : BaseCallCommand<string>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "demo.stop";

    /// <summary>Creates a new <see cref="DemoStopCommand"/> command.</summary>
    public static DemoStopCommand Create()
    {
        var cmd = CreatePackage<DemoStopCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
