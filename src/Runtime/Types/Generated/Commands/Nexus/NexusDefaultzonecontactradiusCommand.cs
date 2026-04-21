using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>Default distance between zones to allow boat travel, if map.contactRadius isn't set in the nexus (uses normalized coordinates)</summary>
/// <remarks>Full RCON name: <c>nexus.defaultzonecontactradius</c></remarks>
public sealed class NexusDefaultzonecontactradiusCommand : BaseConVarCommand<float>
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "nexus.defaultzonecontactradius";

    /// <summary>Reads the current value of <c>nexus.defaultzonecontactradius</c>.</summary>
    public static NexusDefaultzonecontactradiusCommand CreateGet()
    {
        var cmd = CreatePackage<NexusDefaultzonecontactradiusCommand>();
        cmd.Content = CommandFullName;
        return cmd;
    }

    /// <summary>Sets <c>nexus.defaultzonecontactradius</c> to <paramref name="value"/>.</summary>
    public static NexusDefaultzonecontactradiusCommand CreateSet(float value)
    {
        var cmd = CreatePackage<NexusDefaultzonecontactradiusCommand>();
        cmd.Content = $"{CommandFullName} {value}";
        return cmd;
    }
}
