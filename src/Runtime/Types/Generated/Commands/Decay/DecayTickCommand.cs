using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Interval in seconds between decay processing ticks; default is 10 minutes; lower values cause buildings to lose health more frequently</summary>
/// <remarks>Full RCON name: <c>decay.tick</c></remarks>
public sealed class DecayTickCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "decay.tick";

    /// <summary>Reads the current value of <c>decay.tick</c>.</summary>
    public static DecayTickCommand CreateGet()
    {
        var cmd = CreatePackage<DecayTickCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>decay.tick</c> to <paramref name="value"/>.</summary>
    public static DecayTickCommand CreateSet(float value)
    {
        var cmd = CreatePackage<DecayTickCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
