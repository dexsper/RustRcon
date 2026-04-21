using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>aithinkmanager.petframebudgetms</c>.</summary>
/// <remarks>Full RCON name: <c>aithinkmanager.petframebudgetms</c></remarks>
public sealed class AithinkmanagerPetframebudgetmsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "aithinkmanager.petframebudgetms";

    /// <summary>Reads the current value of <c>aithinkmanager.petframebudgetms</c>.</summary>
    public static AithinkmanagerPetframebudgetmsCommand CreateGet()
    {
        var cmd = CreatePackage<AithinkmanagerPetframebudgetmsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>aithinkmanager.petframebudgetms</c> to <paramref name="value"/>.</summary>
    public static AithinkmanagerPetframebudgetmsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AithinkmanagerPetframebudgetmsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
