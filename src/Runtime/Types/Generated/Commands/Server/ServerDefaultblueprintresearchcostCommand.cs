using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How much scrap is required to research default blueprints</summary>
/// <remarks>Full RCON name: <c>server.defaultblueprintresearchcost</c></remarks>
public sealed class ServerDefaultblueprintresearchcostCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.defaultblueprintresearchcost";

    /// <summary>Reads the current value of <c>server.defaultblueprintresearchcost</c>.</summary>
    public static ServerDefaultblueprintresearchcostCommand CreateGet()
    {
        var cmd = CreatePackage<ServerDefaultblueprintresearchcostCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.defaultblueprintresearchcost</c> to <paramref name="value"/>.</summary>
    public static ServerDefaultblueprintresearchcostCommand CreateSet(int value)
    {
        var cmd = CreatePackage<ServerDefaultblueprintresearchcostCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
