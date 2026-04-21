using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>baseplayer.lifestoryframebudgetms</c>.</summary>
/// <remarks>Full RCON name: <c>baseplayer.lifestoryframebudgetms</c></remarks>
public sealed class BaseplayerLifestoryframebudgetmsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "baseplayer.lifestoryframebudgetms";

    /// <summary>Reads the current value of <c>baseplayer.lifestoryframebudgetms</c>.</summary>
    public static BaseplayerLifestoryframebudgetmsCommand CreateGet()
    {
        var cmd = CreatePackage<BaseplayerLifestoryframebudgetmsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>baseplayer.lifestoryframebudgetms</c> to <paramref name="value"/>.</summary>
    public static BaseplayerLifestoryframebudgetmsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BaseplayerLifestoryframebudgetmsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
