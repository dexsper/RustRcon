using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>construct.frameminutes</c>.</summary>
/// <remarks>Full RCON name: <c>construct.frameminutes</c></remarks>
public sealed class ConstructFrameminutesCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "construct.frameminutes";

    /// <summary>Reads the current value of <c>construct.frameminutes</c>.</summary>
    public static ConstructFrameminutesCommand CreateGet()
    {
        var cmd = CreatePackage<ConstructFrameminutesCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>construct.frameminutes</c> to <paramref name="value"/>.</summary>
    public static ConstructFrameminutesCommand CreateSet(float value)
    {
        var cmd = CreatePackage<ConstructFrameminutesCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
