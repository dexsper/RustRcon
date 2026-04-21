using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, the server native profiler runs in immediate mode, capturing every frame rather than sampling; more accurate but higher overhead</summary>
/// <remarks>Full RCON name: <c>profile.immediatemodeenabled</c></remarks>
public sealed class ProfileImmediatemodeenabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "profile.immediatemodeenabled";

    /// <summary>Reads the current value of <c>profile.immediatemodeenabled</c>.</summary>
    public static ProfileImmediatemodeenabledCommand CreateGet()
    {
        var cmd = CreatePackage<ProfileImmediatemodeenabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>profile.immediatemodeenabled</c> to <paramref name="value"/>.</summary>
    public static ProfileImmediatemodeenabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ProfileImmediatemodeenabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
