using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, AI updates are spliced across multiple frames to spread CPU cost; disable to run all AI updates synchronously every tick</summary>
/// <remarks>Full RCON name: <c>ai.spliceupdates</c></remarks>
public sealed class AiSpliceupdatesCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ai.spliceupdates";

    /// <summary>Reads the current value of <c>ai.spliceupdates</c>.</summary>
    public static AiSpliceupdatesCommand CreateGet()
    {
        var cmd = CreatePackage<AiSpliceupdatesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ai.spliceupdates</c> to <paramref name="value"/>.</summary>
    public static AiSpliceupdatesCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AiSpliceupdatesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
