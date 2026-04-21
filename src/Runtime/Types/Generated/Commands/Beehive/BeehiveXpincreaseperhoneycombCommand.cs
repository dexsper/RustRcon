using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How much the Nucleus's XP should be increased per honeycomb generated</summary>
/// <remarks>Full RCON name: <c>beehive.xpincreaseperhoneycomb</c></remarks>
public sealed class BeehiveXpincreaseperhoneycombCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "beehive.xpincreaseperhoneycomb";

    /// <summary>Reads the current value of <c>beehive.xpincreaseperhoneycomb</c>.</summary>
    public static BeehiveXpincreaseperhoneycombCommand CreateGet()
    {
        var cmd = CreatePackage<BeehiveXpincreaseperhoneycombCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>beehive.xpincreaseperhoneycomb</c> to <paramref name="value"/>.</summary>
    public static BeehiveXpincreaseperhoneycombCommand CreateSet(int value)
    {
        var cmd = CreatePackage<BeehiveXpincreaseperhoneycombCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
