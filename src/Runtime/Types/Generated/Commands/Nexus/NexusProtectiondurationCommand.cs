using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Maximum time in seconds to keep transfer protection enabled on entities</summary>
/// <remarks>Full RCON name: <c>nexus.protectionduration</c></remarks>
public sealed class NexusProtectiondurationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "nexus.protectionduration";

    /// <summary>Reads the current value of <c>nexus.protectionduration</c>.</summary>
    public static NexusProtectiondurationCommand CreateGet()
    {
        var cmd = CreatePackage<NexusProtectiondurationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>nexus.protectionduration</c> to <paramref name="value"/>.</summary>
    public static NexusProtectiondurationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<NexusProtectiondurationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
