using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Enables plant light detection — growable plants will check nearby light sources each tick and adjust growth speed and quality accordingly</summary>
/// <remarks>Full RCON name: <c>server.plantlightdetection</c></remarks>
public sealed class ServerPlantlightdetectionCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "server.plantlightdetection";

    /// <summary>Reads the current value of <c>server.plantlightdetection</c>.</summary>
    public static ServerPlantlightdetectionCommand CreateGet()
    {
        var cmd = CreatePackage<ServerPlantlightdetectionCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>server.plantlightdetection</c> to <paramref name="value"/>.</summary>
    public static ServerPlantlightdetectionCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ServerPlantlightdetectionCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
