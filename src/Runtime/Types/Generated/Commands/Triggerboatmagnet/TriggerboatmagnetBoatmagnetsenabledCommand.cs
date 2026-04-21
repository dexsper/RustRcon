using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, boat building station magnets are active and will magnetically attract compatible boat building blocks into position</summary>
/// <remarks>Full RCON name: <c>triggerboatmagnet.boatmagnetsenabled</c></remarks>
public sealed class TriggerboatmagnetBoatmagnetsenabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "triggerboatmagnet.boatmagnetsenabled";

    /// <summary>Reads the current value of <c>triggerboatmagnet.boatmagnetsenabled</c>.</summary>
    public static TriggerboatmagnetBoatmagnetsenabledCommand CreateGet()
    {
        var cmd = CreatePackage<TriggerboatmagnetBoatmagnetsenabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>triggerboatmagnet.boatmagnetsenabled</c> to <paramref name="value"/>.</summary>
    public static TriggerboatmagnetBoatmagnetsenabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<TriggerboatmagnetBoatmagnetsenabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
