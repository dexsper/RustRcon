using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>antihack.admincheat</c>.</summary>
/// <remarks>Full RCON name: <c>antihack.admincheat</c></remarks>
public sealed class AntihackAdmincheatCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "antihack.admincheat";

    /// <summary>Reads the current value of <c>antihack.admincheat</c>.</summary>
    public static AntihackAdmincheatCommand CreateGet()
    {
        var cmd = CreatePackage<AntihackAdmincheatCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>antihack.admincheat</c> to <paramref name="value"/>.</summary>
    public static AntihackAdmincheatCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<AntihackAdmincheatCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
