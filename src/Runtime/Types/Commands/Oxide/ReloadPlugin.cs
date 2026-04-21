using RustRcon.Types.Commands.Base;

namespace RustRcon.Types.Commands.Oxide;

/// <summary>Reloads an Oxide plugin by file name (<c>o.reload</c>).</summary>
public sealed class ReloadPlugin : BaseCommand
{
    /// <param name="pluginName">Plugin file name without extension.</param>
    public static ReloadPlugin Create(string pluginName)
    {
        if (pluginName is null) throw new ArgumentNullException(nameof(pluginName));
        var command = CreatePackage<ReloadPlugin>();
        command.Content = $"o.reload {pluginName}";
        return command;
    }
}
