using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Nagle time, in microseconds</summary>
/// <remarks>Full RCON name: <c>global.steamnagletime</c></remarks>
public sealed class GlobalSteamnagletimeCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "global.steamnagletime";

    /// <summary>Reads the current value of <c>global.steamnagletime</c>.</summary>
    public static GlobalSteamnagletimeCommand CreateGet()
    {
        var cmd = CreatePackage<GlobalSteamnagletimeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>global.steamnagletime</c> to <paramref name="value"/>.</summary>
    public static GlobalSteamnagletimeCommand CreateSet(int value)
    {
        var cmd = CreatePackage<GlobalSteamnagletimeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
