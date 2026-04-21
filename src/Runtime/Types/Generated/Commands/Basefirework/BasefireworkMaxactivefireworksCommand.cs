using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>RCON command: <c>basefirework.maxactivefireworks</c>.</summary>
/// <remarks>Full RCON name: <c>basefirework.maxactivefireworks</c></remarks>
public sealed class BasefireworkMaxactivefireworksCommand : BaseConVarCommand<int>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "basefirework.maxactivefireworks";

    /// <summary>Reads the current value of <c>basefirework.maxactivefireworks</c>.</summary>
    public static BasefireworkMaxactivefireworksCommand CreateGet()
    {
        var cmd = CreatePackage<BasefireworkMaxactivefireworksCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>basefirework.maxactivefireworks</c> to <paramref name="value"/>.</summary>
    public static BasefireworkMaxactivefireworksCommand CreateSet(int value)
    {
        var cmd = CreatePackage<BasefireworkMaxactivefireworksCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
