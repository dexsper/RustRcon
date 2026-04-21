using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>solarpanel.sunupdatebudgetms</c>.</summary>
/// <remarks>Full RCON name: <c>solarpanel.sunupdatebudgetms</c></remarks>
public sealed class SolarpanelSunupdatebudgetmsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "solarpanel.sunupdatebudgetms";

    /// <summary>Reads the current value of <c>solarpanel.sunupdatebudgetms</c>.</summary>
    public static SolarpanelSunupdatebudgetmsCommand CreateGet()
    {
        var cmd = CreatePackage<SolarpanelSunupdatebudgetmsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>solarpanel.sunupdatebudgetms</c> to <paramref name="value"/>.</summary>
    public static SolarpanelSunupdatebudgetmsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<SolarpanelSunupdatebudgetmsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
