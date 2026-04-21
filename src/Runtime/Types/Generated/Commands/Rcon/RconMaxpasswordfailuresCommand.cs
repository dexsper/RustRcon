using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>How many password failures before banning an RCON client's IP (default: 5)</summary>
/// <remarks>Full RCON name: <c>rcon.maxpasswordfailures</c></remarks>
public sealed class RconMaxpasswordfailuresCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "rcon.maxpasswordfailures";

    /// <summary>Reads the current value of <c>rcon.maxpasswordfailures</c>.</summary>
    public static RconMaxpasswordfailuresCommand CreateGet()
    {
        var cmd = CreatePackage<RconMaxpasswordfailuresCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>rcon.maxpasswordfailures</c> to <paramref name="value"/>.</summary>
    public static RconMaxpasswordfailuresCommand CreateSet(int value)
    {
        var cmd = CreatePackage<RconMaxpasswordfailuresCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
