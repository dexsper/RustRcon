using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Number of AI think ticks per second; default is 5 (every 200ms); higher values make AI more responsive at higher CPU cost</summary>
/// <remarks>Full RCON name: <c>ai.tickrate</c></remarks>
public sealed class AiTickrateCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.tickrate";

    /// <summary>Reads the current value of <c>ai.tickrate</c>.</summary>
    public static AiTickrateCommand CreateGet()
    {
        var cmd = CreatePackage<AiTickrateCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.tickrate</c> to <paramref name="value"/>.</summary>
    public static AiTickrateCommand CreateSet(float value)
    {
        var cmd = CreatePackage<AiTickrateCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
