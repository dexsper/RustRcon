using RustRcon.Types.Commands.Base;

namespace RustRcon.Types.Commands.Oxide;

/// <summary>Loads an Oxide plugin by file name (<c>o.load</c>).</summary>
public sealed class LoadPlugin : BaseCommand
{
    /// <param name="pluginName">Plugin file name without extension.</param>
    public static LoadPlugin Create(string pluginName)
    {
        if (pluginName is null) throw new ArgumentNullException(nameof(pluginName));
        var command = CreatePackage<LoadPlugin>();
        command.Content = $"o.load {pluginName}";
        return command;
    }
}
