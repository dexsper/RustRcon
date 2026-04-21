using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Time between growls when stalking a player</summary>
/// <remarks>Full RCON name: <c>tigersneaktelegraphgrowl.mintimebetweengrowls</c></remarks>
public sealed class TigersneaktelegraphgrowlMintimebetweengrowlsCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "tigersneaktelegraphgrowl.mintimebetweengrowls";

    /// <summary>Reads the current value of <c>tigersneaktelegraphgrowl.mintimebetweengrowls</c>.</summary>
    public static TigersneaktelegraphgrowlMintimebetweengrowlsCommand CreateGet()
    {
        var cmd = CreatePackage<TigersneaktelegraphgrowlMintimebetweengrowlsCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>tigersneaktelegraphgrowl.mintimebetweengrowls</c> to <paramref name="value"/>.</summary>
    public static TigersneaktelegraphgrowlMintimebetweengrowlsCommand CreateSet(float value)
    {
        var cmd = CreatePackage<TigersneaktelegraphgrowlMintimebetweengrowlsCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
