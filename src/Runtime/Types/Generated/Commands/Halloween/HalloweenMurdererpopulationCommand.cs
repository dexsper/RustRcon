using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Population active on the server, per square km</summary>
/// <remarks>Full RCON name: <c>halloween.murdererpopulation</c></remarks>
public sealed class HalloweenMurdererpopulationCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "halloween.murdererpopulation";

    /// <summary>Reads the current value of <c>halloween.murdererpopulation</c>.</summary>
    public static HalloweenMurdererpopulationCommand CreateGet()
    {
        var cmd = CreatePackage<HalloweenMurdererpopulationCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>halloween.murdererpopulation</c> to <paramref name="value"/>.</summary>
    public static HalloweenMurdererpopulationCommand CreateSet(float value)
    {
        var cmd = CreatePackage<HalloweenMurdererpopulationCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
