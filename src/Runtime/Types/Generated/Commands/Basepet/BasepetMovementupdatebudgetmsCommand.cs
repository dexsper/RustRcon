using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>basepet.movementupdatebudgetms</c>.</summary>
/// <remarks>Full RCON name: <c>basepet.movementupdatebudgetms</c></remarks>
public sealed class BasepetMovementupdatebudgetmsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "basepet.movementupdatebudgetms";

    /// <summary>Reads the current value of <c>basepet.movementupdatebudgetms</c>.</summary>
    public static BasepetMovementupdatebudgetmsCommand CreateGet()
    {
        var cmd = CreatePackage<BasepetMovementupdatebudgetmsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>basepet.movementupdatebudgetms</c> to <paramref name="value"/>.</summary>
    public static BasepetMovementupdatebudgetmsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BasepetMovementupdatebudgetmsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
