using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How much of a tax to apply to tech unlocks at a level 3 workbench. 10 = additional 10% scrap cost</summary>
/// <remarks>Full RCON name: <c>server.workbenchtaxrate3</c></remarks>
public sealed class ServerWorkbenchtaxrate3Command : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.workbenchtaxrate3";

    /// <summary>Reads the current value of <c>server.workbenchtaxrate3</c>.</summary>
    public static ServerWorkbenchtaxrate3Command CreateGet()
    {
        var cmd = CreatePackage<ServerWorkbenchtaxrate3Command>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.workbenchtaxrate3</c> to <paramref name="value"/>.</summary>
    public static ServerWorkbenchtaxrate3Command CreateSet(float value)
    {
        var cmd = CreatePackage<ServerWorkbenchtaxrate3Command>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
