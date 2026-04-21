using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>add &lt;convar&gt; &lt;amount&gt; - adds amount to convar</summary>
/// <remarks>Full RCON name: <c>meta.add</c></remarks>
public sealed class MetaAddCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "meta.add";

    /// <summary>Creates a new <see cref="MetaAddCommand"/> command.</summary>
    public static MetaAddCommand Create()
    {
        var cmd = CreatePackage<MetaAddCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
