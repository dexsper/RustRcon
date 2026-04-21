namespace RustRcon.Types;

/// <summary>
///     Provides a simple logging abstraction.
/// </summary>
public interface ILogger
{
    /// <summary>Writes a log message.</summary>
    void Log(string message);
}
