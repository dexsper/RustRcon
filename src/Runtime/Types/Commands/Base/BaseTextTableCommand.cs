using RustRcon.Types.Response;
using RustRcon.Types.Response.Server;

namespace RustRcon.Types.Commands.Base;

/// <summary>
///     Base for RCON commands that reply with a <c>TextTable</c> — either as a
///     space-padded text table or as a JSON array (when called with <c>--json</c>).
/// </summary>
/// <remarks>
///     After <see cref="BaseCommand.Complete"/> is called, <see cref="Result"/> holds the
///     parsed response with column-based row access via <see cref="TextTableResponse.Rows"/>.
/// </remarks>
public abstract class BaseTextTableCommand : BaseCommand
{
    /// <summary>
    ///     The parsed response, available after <see cref="BaseCommand.Complete"/> is called.
    /// </summary>
    public TextTableResponse? Result { get; private set; }

    /// <inheritdoc/>
    public override void Complete(ServerResponse response)
    {
        if (Completed) return;
        base.Complete(response);
        Result = TextTableResponse.Parse(response.Content);
    }

    /// <inheritdoc/>
    protected override void EnterPool()
    {
        base.EnterPool();
        Result = null;
    }
}
