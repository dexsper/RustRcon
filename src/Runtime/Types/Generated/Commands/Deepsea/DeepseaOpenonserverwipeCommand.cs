using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Should the deep sea open as soon as the server wiped?</summary>
/// <remarks>Full RCON name: <c>deepsea.openonserverwipe</c></remarks>
public sealed class DeepseaOpenonserverwipeCommand : BaseConVarCommand<bool>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.openonserverwipe";

    /// <summary>Reads the current value of <c>deepsea.openonserverwipe</c>.</summary>
    public static DeepseaOpenonserverwipeCommand CreateGet()
    {
        var cmd = CreatePackage<DeepseaOpenonserverwipeCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>deepsea.openonserverwipe</c> to <paramref name="value"/>.</summary>
    public static DeepseaOpenonserverwipeCommand CreateSet(bool value)
    {
        var cmd = CreatePackage<DeepseaOpenonserverwipeCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
