using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, NavMesh destinations are sampled to the nearest valid NavMesh position before being set; prevents NPCs getting stuck off-mesh</summary>
/// <remarks>Full RCON name: <c>ai.setdestinationsamplenavmesh</c></remarks>
public sealed class AiSetdestinationsamplenavmeshCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.setdestinationsamplenavmesh";

    /// <summary>Reads the current value of <c>ai.setdestinationsamplenavmesh</c>.</summary>
    public static AiSetdestinationsamplenavmeshCommand CreateGet()
    {
        var cmd = CreatePackage<AiSetdestinationsamplenavmeshCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.setdestinationsamplenavmesh</c> to <paramref name="value"/>.</summary>
    public static AiSetdestinationsamplenavmeshCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiSetdestinationsamplenavmeshCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
