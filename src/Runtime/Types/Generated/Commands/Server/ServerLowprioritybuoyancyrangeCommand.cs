using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If no players are in this range kayaks, boogie boards and inner tubes will switch to a cheaper buoyancy system</summary>
/// <remarks>Full RCON name: <c>server.lowprioritybuoyancyrange</c></remarks>
public sealed class ServerLowprioritybuoyancyrangeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.lowprioritybuoyancyrange";

    /// <summary>Reads the current value of <c>server.lowprioritybuoyancyrange</c>.</summary>
    public static ServerLowprioritybuoyancyrangeCommand CreateGet()
    {
        var cmd = CreatePackage<ServerLowprioritybuoyancyrangeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.lowprioritybuoyancyrange</c> to <paramref name="value"/>.</summary>
    public static ServerLowprioritybuoyancyrangeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerLowprioritybuoyancyrangeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
