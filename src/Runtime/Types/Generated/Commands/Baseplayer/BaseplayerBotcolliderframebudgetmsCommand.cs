using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Per-frame CPU budget in milliseconds for the bot collider work queue that updates NPC physics colliders</summary>
/// <remarks>Full RCON name: <c>baseplayer.botcolliderframebudgetms</c></remarks>
public sealed class BaseplayerBotcolliderframebudgetmsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "baseplayer.botcolliderframebudgetms";

    /// <summary>Reads the current value of <c>baseplayer.botcolliderframebudgetms</c>.</summary>
    public static BaseplayerBotcolliderframebudgetmsCommand CreateGet()
    {
        var cmd = CreatePackage<BaseplayerBotcolliderframebudgetmsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>baseplayer.botcolliderframebudgetms</c> to <paramref name="value"/>.</summary>
    public static BaseplayerBotcolliderframebudgetmsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BaseplayerBotcolliderframebudgetmsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
