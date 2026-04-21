using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) When enabled, this system is globally active; disable to deactivate the system for the current session</summary>
/// <remarks>Full RCON name: <c>chat.enabled</c></remarks>
public sealed class ChatEnabledCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "chat.enabled";

    /// <summary>Reads the current value of <c>chat.enabled</c>.</summary>
    public static ChatEnabledCommand CreateGet()
    {
        var cmd = CreatePackage<ChatEnabledCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>chat.enabled</c> to <paramref name="value"/>.</summary>
    public static ChatEnabledCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<ChatEnabledCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
