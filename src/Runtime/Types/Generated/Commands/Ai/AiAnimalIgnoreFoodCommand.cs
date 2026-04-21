using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>If animal_ignore_food is true, animals will not sense food sources or interact with them (server optimization). (default: true)</summary>
/// <remarks>Full RCON name: <c>ai.animal_ignore_food</c></remarks>
public sealed class AiAnimalIgnoreFoodCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.animal_ignore_food";

    /// <summary>Reads the current value of <c>ai.animal_ignore_food</c>.</summary>
    public static AiAnimalIgnoreFoodCommand CreateGet()
    {
        var cmd = CreatePackage<AiAnimalIgnoreFoodCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.animal_ignore_food</c> to <paramref name="value"/>.</summary>
    public static AiAnimalIgnoreFoodCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiAnimalIgnoreFoodCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
