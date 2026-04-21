using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Sets the time in seconds until the deep sea re-opens after a wipe; useful for skipping the cooldown period during testing</summary>
/// <remarks>Full RCON name: <c>deepsea.settimetonextopening</c></remarks>
public sealed class DeepseaSettimetonextopeningCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "deepsea.settimetonextopening";

    /// <summary>Creates a new <see cref="DeepseaSettimetonextopeningCommand"/> command.</summary>
    public static DeepseaSettimetonextopeningCommand Create(float value)
    {
        var cmd = CreatePackage<DeepseaSettimetonextopeningCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
