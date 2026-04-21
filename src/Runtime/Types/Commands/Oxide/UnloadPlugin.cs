using RustRcon.Types.Commands.Base;

namespace RustRcon.Types.Commands.Oxide;

/// <summary>Unloads an Oxide plugin by file name (<c>o.unload</c>).</summary>
public sealed class UnloadPlugin : BaseCommand
{
    /// <param name="pluginName">Plugin file name without extension.</param>
    public static UnloadPlugin Create(string pluginName)
    {
        if (pluginName is null) throw new ArgumentNullException(nameof(pluginName));
        var command = CreatePackage<UnloadPlugin>();
        command.Content = $"o.unload {pluginName}";
        return command;
    }
}
