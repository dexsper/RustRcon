using RustRcon.Types.Response.Server;

namespace RustRcon.Types.Commands.Base;

/// <summary>
///     Base class for RCON commands that send a request and receive a
///     <see cref="ServerResponse"/>.
/// </summary>
public abstract class BaseCommand : BasePackage
{
    /// <summary>The raw server response received for this command.</summary>
    public ServerResponse? ServerResponse { get; protected set; }

    /// <summary>
    ///     <see langword="true"/> once <see cref="Complete"/> has been called for the
    ///     first time.
    /// </summary>
    public bool Completed { get; private set; }

    /// <summary>
    ///     Stores the server response and marks this command as completed.
    ///     Subsequent calls are no-ops.
    /// </summary>
    /// <param name="response">The response received from the server.</param>
    public virtual void Complete(ServerResponse response)
    {
        if (Completed) return;
        ServerResponse = response;
        Completed = true;
    }

    protected override void EnterPool()
    {
        base.EnterPool();
        ServerResponse?.Dispose();
        ServerResponse = null;
        Completed = false;
    }
}
