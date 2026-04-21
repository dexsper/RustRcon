using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Time offset in hours from the nexus clock</summary>
/// <remarks>Full RCON name: <c>nexus.timeoffset</c></remarks>
public sealed class NexusTimeoffsetCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "nexus.timeoffset";

    /// <summary>Reads the current value of <c>nexus.timeoffset</c>.</summary>
    public static NexusTimeoffsetCommand CreateGet()
    {
        var cmd = CreatePackage<NexusTimeoffsetCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>nexus.timeoffset</c> to <paramref name="value"/>.</summary>
    public static NexusTimeoffsetCommand CreateSet(float value)
    {
        var cmd = CreatePackage<NexusTimeoffsetCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
