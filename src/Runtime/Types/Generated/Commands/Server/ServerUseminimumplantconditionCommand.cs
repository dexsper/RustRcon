using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, plants that would normally be in a critically poor condition are given a minimum viable condition score instead of immediately dying</summary>
/// <remarks>Full RCON name: <c>server.useminimumplantcondition</c></remarks>
public sealed class ServerUseminimumplantconditionCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.useminimumplantcondition";

    /// <summary>Reads the current value of <c>server.useminimumplantcondition</c>.</summary>
    public static ServerUseminimumplantconditionCommand CreateGet()
    {
        var cmd = CreatePackage<ServerUseminimumplantconditionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.useminimumplantcondition</c> to <paramref name="value"/>.</summary>
    public static ServerUseminimumplantconditionCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerUseminimumplantconditionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
