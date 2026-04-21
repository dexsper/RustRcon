using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>cctv.inputbudgetms</c>.</summary>
/// <remarks>Full RCON name: <c>cctv.inputbudgetms</c></remarks>
public sealed class CctvInputbudgetmsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "cctv.inputbudgetms";

    /// <summary>Reads the current value of <c>cctv.inputbudgetms</c>.</summary>
    public static CctvInputbudgetmsCommand CreateGet()
    {
        var cmd = CreatePackage<CctvInputbudgetmsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>cctv.inputbudgetms</c> to <paramref name="value"/>.</summary>
    public static CctvInputbudgetmsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<CctvInputbudgetmsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
