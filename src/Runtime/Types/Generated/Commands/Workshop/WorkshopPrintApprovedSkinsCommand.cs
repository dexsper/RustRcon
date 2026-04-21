using RustRcon.Types;
using RustRcon.Types.Commands.Base;

namespace RustRcon.Generated.Commands;

/// <summary>(Generated) Prints a list of all workshop-approved skins on the server with their item short names and approved skin IDs</summary>
/// <remarks>Full RCON name: <c>workshop.print_approved_skins</c></remarks>
public sealed class WorkshopPrintApprovedSkinsCommand : BaseTextTableCommand
{
    /// <summary>Full dotted RCON name.</summary>
    public const string CommandFullName = "workshop.print_approved_skins";

    /// <summary>Creates a new <see cref="WorkshopPrintApprovedSkinsCommand"/> command.</summary>
    public static WorkshopPrintApprovedSkinsCommand Create(bool json = false)
    {
        var cmd = CreatePackage<WorkshopPrintApprovedSkinsCommand>();
        var content = new System.Text.StringBuilder(CommandFullName);
        if (json) content.Append(" --json");
        cmd.Content = content.ToString();
        return cmd;
    }
}
