using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Do any kind of scientists spawn on the map (default: true)</summary>
/// <remarks>Full RCON name: <c>ai.scientist_spawners_enabled</c></remarks>
public sealed class AiScientistSpawnersEnabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.scientist_spawners_enabled";

    /// <summary>Reads the current value of <c>ai.scientist_spawners_enabled</c>.</summary>
    public static AiScientistSpawnersEnabledCommand CreateGet()
    {
        var cmd = CreatePackage<AiScientistSpawnersEnabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.scientist_spawners_enabled</c> to <paramref name="value"/>.</summary>
    public static AiScientistSpawnersEnabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiScientistSpawnersEnabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
