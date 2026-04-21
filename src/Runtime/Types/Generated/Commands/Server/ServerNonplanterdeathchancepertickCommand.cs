using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Probability (0–1) per growth tick that a plant growing outside a planter box will die; default 0.005 means a 0.5% chance each tick</summary>
/// <remarks>Full RCON name: <c>server.nonplanterdeathchancepertick</c></remarks>
public sealed class ServerNonplanterdeathchancepertickCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.nonplanterdeathchancepertick";

    /// <summary>Reads the current value of <c>server.nonplanterdeathchancepertick</c>.</summary>
    public static ServerNonplanterdeathchancepertickCommand CreateGet()
    {
        var cmd = CreatePackage<ServerNonplanterdeathchancepertickCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.nonplanterdeathchancepertick</c> to <paramref name="value"/>.</summary>
    public static ServerNonplanterdeathchancepertickCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerNonplanterdeathchancepertickCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
