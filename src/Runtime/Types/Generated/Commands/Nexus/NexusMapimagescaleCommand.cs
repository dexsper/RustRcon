using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Scale of the map to render and upload to the nexus</summary>
/// <remarks>Full RCON name: <c>nexus.mapimagescale</c></remarks>
public sealed class NexusMapimagescaleCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "nexus.mapimagescale";

    /// <summary>Reads the current value of <c>nexus.mapimagescale</c>.</summary>
    public static NexusMapimagescaleCommand CreateGet()
    {
        var cmd = CreatePackage<NexusMapimagescaleCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>nexus.mapimagescale</c> to <paramref name="value"/>.</summary>
    public static NexusMapimagescaleCommand CreateSet(float value)
    {
        var cmd = CreatePackage<NexusMapimagescaleCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
