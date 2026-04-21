using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How long per frame to spend on industrial jobs</summary>
/// <remarks>Full RCON name: <c>server.industrialframebudgetms</c></remarks>
public sealed class ServerIndustrialframebudgetmsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.industrialframebudgetms";

    /// <summary>Reads the current value of <c>server.industrialframebudgetms</c>.</summary>
    public static ServerIndustrialframebudgetmsCommand CreateGet()
    {
        var cmd = CreatePackage<ServerIndustrialframebudgetmsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.industrialframebudgetms</c> to <paramref name="value"/>.</summary>
    public static ServerIndustrialframebudgetmsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ServerIndustrialframebudgetmsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
