using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Failsafe toggle that must be true before any alwaysOn commands work; prevents items from accidentally entering the always-on state outside of creative mode</summary>
/// <remarks>Full RCON name: <c>creative.alwaysonenabled</c></remarks>
public sealed class CreativeAlwaysonenabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "creative.alwaysonenabled";

    /// <summary>Reads the current value of <c>creative.alwaysonenabled</c>.</summary>
    public static CreativeAlwaysonenabledCommand CreateGet()
    {
        var cmd = CreatePackage<CreativeAlwaysonenabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>creative.alwaysonenabled</c> to <paramref name="value"/>.</summary>
    public static CreativeAlwaysonenabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<CreativeAlwaysonenabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
