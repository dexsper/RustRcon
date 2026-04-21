using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Will spawn eggs for bots, only for debug purposes - don't enable it!</summary>
/// <remarks>Full RCON name: <c>egghuntevent.includebots</c></remarks>
public sealed class EgghunteventIncludebotsCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "egghuntevent.includebots";

    /// <summary>Reads the current value of <c>egghuntevent.includebots</c>.</summary>
    public static EgghunteventIncludebotsCommand CreateGet()
    {
        var cmd = CreatePackage<EgghunteventIncludebotsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>egghuntevent.includebots</c> to <paramref name="value"/>.</summary>
    public static EgghunteventIncludebotsCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<EgghunteventIncludebotsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
