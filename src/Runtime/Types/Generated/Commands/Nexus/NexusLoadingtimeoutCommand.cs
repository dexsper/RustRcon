using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Time in seconds to keep players in the loading state before going to sleep</summary>
/// <remarks>Full RCON name: <c>nexus.loadingtimeout</c></remarks>
public sealed class NexusLoadingtimeoutCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "nexus.loadingtimeout";

    /// <summary>Reads the current value of <c>nexus.loadingtimeout</c>.</summary>
    public static NexusLoadingtimeoutCommand CreateGet()
    {
        var cmd = CreatePackage<NexusLoadingtimeoutCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>nexus.loadingtimeout</c> to <paramref name="value"/>.</summary>
    public static NexusLoadingtimeoutCommand CreateSet(float value)
    {
        var cmd = CreatePackage<NexusLoadingtimeoutCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
