using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Per-frame CPU budget in milliseconds for processing the player relationship (contacts/team) update queue</summary>
/// <remarks>Full RCON name: <c>baseplayer.relationshipupdatequeueframebudgetms</c></remarks>
public sealed class BaseplayerRelationshipupdatequeueframebudgetmsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "baseplayer.relationshipupdatequeueframebudgetms";

    /// <summary>Reads the current value of <c>baseplayer.relationshipupdatequeueframebudgetms</c>.</summary>
    public static BaseplayerRelationshipupdatequeueframebudgetmsCommand CreateGet()
    {
        var cmd = CreatePackage<BaseplayerRelationshipupdatequeueframebudgetmsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>baseplayer.relationshipupdatequeueframebudgetms</c> to <paramref name="value"/>.</summary>
    public static BaseplayerRelationshipupdatequeueframebudgetmsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<BaseplayerRelationshipupdatequeueframebudgetmsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
