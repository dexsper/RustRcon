using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Minimum interval in seconds between IO entity logic updates; controls how quickly electrical signals propagate through the network</summary>
/// <remarks>Full RCON name: <c>ioentity.responsetime</c></remarks>
public sealed class IoentityResponsetimeCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "ioentity.responsetime";

    /// <summary>Reads the current value of <c>ioentity.responsetime</c>.</summary>
    public static IoentityResponsetimeCommand CreateGet()
    {
        var cmd = CreatePackage<IoentityResponsetimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>ioentity.responsetime</c> to <paramref name="value"/>.</summary>
    public static IoentityResponsetimeCommand CreateSet(float value)
    {
        var cmd = CreatePackage<IoentityResponsetimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
