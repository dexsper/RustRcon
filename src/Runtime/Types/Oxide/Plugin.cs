namespace RustRcon.Types.Oxide;

/// <summary>Describes an installed Oxide plugin as reported by <c>o.plugins</c>.</summary>
public readonly struct Plugin
{
    /// <param name="filename">Plugin file name (including extension).</param>
    /// <param name="name">Human-readable plugin title.</param>
    /// <param name="version">Plugin version string.</param>
    /// <param name="author">Plugin author name.</param>
    /// <param name="totalHookTime">Cumulative hook execution time string.</param>
    /// <param name="totalHookMemory">Cumulative hook memory allocation string.</param>
    public Plugin(string filename,
        string name,
        string version,
        string author,
        string totalHookTime,
        string totalHookMemory
    )
    {
        Filename = filename;
        Name = name;
        Version = version;
        Author = author;
        TotalHookTime = totalHookTime;
        TotalHookMemory = totalHookMemory;
    }

    public string Filename { get; }
    public string Name { get; }
    public string Version { get; }
    public string Author { get; }
    public string TotalHookTime { get; }
    public string TotalHookMemory { get; }
}