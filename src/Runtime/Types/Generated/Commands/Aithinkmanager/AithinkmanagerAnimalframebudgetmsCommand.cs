using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>aithinkmanager.animalframebudgetms</c>.</summary>
/// <remarks>Full RCON name: <c>aithinkmanager.animalframebudgetms</c></remarks>
public sealed class AithinkmanagerAnimalframebudgetmsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "aithinkmanager.animalframebudgetms";

    /// <summary>Reads the current value of <c>aithinkmanager.animalframebudgetms</c>.</summary>
    public static AithinkmanagerAnimalframebudgetmsCommand CreateGet()
    {
        var cmd = CreatePackage<AithinkmanagerAnimalframebudgetmsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>aithinkmanager.animalframebudgetms</c> to <paramref name="value"/>.</summary>
    public static AithinkmanagerAnimalframebudgetmsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AithinkmanagerAnimalframebudgetmsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
