using Newtonsoft.Json;
using RustRcon.Types.Response.Server;

namespace RustRcon.Types.Commands.Base;

/// <summary>
///     Base for RCON commands that return a typed result in the server response.
///     The response body is deserialised as <typeparamref name="TResult"/> via JSON.
/// </summary>
/// <typeparam name="TResult">The expected response payload type.</typeparam>
public abstract class BaseCallCommand<TResult> : BaseCommand
{
    /// <summary>The deserialised result, available after <see cref="BaseCommand.Complete"/> is called.</summary>
    public TResult? Result { get; private set; }

    /// <inheritdoc/>
    public override void Complete(ServerResponse response)
    {
        if (Completed) return;
        base.Complete(response);

        try
        {
            Result = JsonConvert.DeserializeObject<TResult>(response.Content);
        }
        catch { }
    }

    protected override void EnterPool()
    {
        base.EnterPool();
        Result = default;
    }
}
