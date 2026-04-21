using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>aithinkmanager.framebudgetms</c>.</summary>
/// <remarks>Full RCON name: <c>aithinkmanager.framebudgetms</c></remarks>
public sealed class AithinkmanagerFramebudgetmsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "aithinkmanager.framebudgetms";

    /// <summary>Reads the current value of <c>aithinkmanager.framebudgetms</c>.</summary>
    public static AithinkmanagerFramebudgetmsCommand CreateGet()
    {
        var cmd = CreatePackage<AithinkmanagerFramebudgetmsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>aithinkmanager.framebudgetms</c> to <paramref name="value"/>.</summary>
    public static AithinkmanagerFramebudgetmsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AithinkmanagerFramebudgetmsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
