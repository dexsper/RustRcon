using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If true, allow RCON connections to subscribe to server events. This could be a performance hit and should only be used if you need it.</summary>
/// <remarks>Full RCON name: <c>rcon.enablesubscriptions</c></remarks>
public sealed class RconEnablesubscriptionsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "rcon.enablesubscriptions";

    /// <summary>Reads the current value of <c>rcon.enablesubscriptions</c>.</summary>
    public static RconEnablesubscriptionsCommand CreateGet()
    {
        var cmd = CreatePackage<RconEnablesubscriptionsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>rcon.enablesubscriptions</c> to <paramref name="value"/>.</summary>
    public static RconEnablesubscriptionsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<RconEnablesubscriptionsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
