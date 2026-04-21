using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Base chance of recovery after incapacitated wounded state</summary>
/// <remarks>Full RCON name: <c>server.incapacitatedrecoverchance</c></remarks>
public sealed class ServerIncapacitatedrecoverchanceCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.incapacitatedrecoverchance";

    /// <summary>Reads the current value of <c>server.incapacitatedrecoverchance</c>.</summary>
    public static ServerIncapacitatedrecoverchanceCommand CreateGet()
    {
        var cmd = CreatePackage<ServerIncapacitatedrecoverchanceCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.incapacitatedrecoverchance</c> to <paramref name="value"/>.</summary>
    public static ServerIncapacitatedrecoverchanceCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerIncapacitatedrecoverchanceCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
