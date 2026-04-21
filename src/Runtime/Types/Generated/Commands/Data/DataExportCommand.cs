using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Exports a named terrain map layer (splatmap, heightmap, biomemap, topologymap, alphamap, watermap) to a .raw file in the persistent data path</summary>
/// <remarks>Full RCON name: <c>data.export</c></remarks>
public sealed class DataExportCommand : BaseCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "data.export";

    /// <summary>Creates a new <see cref="DataExportCommand"/> command.</summary>
    public static DataExportCommand Create()
    {
        var cmd = CreatePackage<DataExportCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }
}
