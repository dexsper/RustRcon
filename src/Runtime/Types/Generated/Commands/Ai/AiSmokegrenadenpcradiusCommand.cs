using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Radius in metres within which a thrown smoke grenade suppresses NPC vision and targeting</summary>
/// <remarks>Full RCON name: <c>ai.smokegrenadenpcradius</c></remarks>
public sealed class AiSmokegrenadenpcradiusCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.smokegrenadenpcradius";

    /// <summary>Reads the current value of <c>ai.smokegrenadenpcradius</c>.</summary>
    public static AiSmokegrenadenpcradiusCommand CreateGet()
    {
        var cmd = CreatePackage<AiSmokegrenadenpcradiusCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.smokegrenadenpcradius</c> to <paramref name="value"/>.</summary>
    public static AiSmokegrenadenpcradiusCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiSmokegrenadenpcradiusCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
