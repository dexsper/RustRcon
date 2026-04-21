using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How much of a tax to apply to tech unlocks at a level 1 workbench. 10 = additional 10% scrap cost</summary>
/// <remarks>Full RCON name: <c>server.workbenchtaxrate1</c></remarks>
public sealed class ServerWorkbenchtaxrate1Command : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.workbenchtaxrate1";

    /// <summary>Reads the current value of <c>server.workbenchtaxrate1</c>.</summary>
    public static ServerWorkbenchtaxrate1Command CreateGet()
    {
        var cmd = CreatePackage<ServerWorkbenchtaxrate1Command>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.workbenchtaxrate1</c> to <paramref name="value"/>.</summary>
    public static ServerWorkbenchtaxrate1Command CreateSet(float value)
    {
        var cmd = CreatePackage<ServerWorkbenchtaxrate1Command>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
