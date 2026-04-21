namespace RustRcon.Generator;

/// <summary>CLI / configuration options for the generator tool.</summary>
public sealed class GeneratorOptions
{
    /// <summary>
    ///     Absolute path to the output directory where generated files are written.
    ///     Defaults to <c>./Generated</c> relative to the working directory.
    /// </summary>
    public string OutputDir { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "Generated");

    /// <summary>
    ///     Local cache directory for the downloaded DLL and version metadata.
    ///     Defaults to <c>%LOCALAPPDATA%/RustRconGenerator</c>.
    /// </summary>
    public string CacheDir { get; set; } = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "RustRconGenerator"
    );

    /// <summary>
    ///     When <see langword="true"/>, always re-download the DLL even if the
    ///     cached version is already current.
    /// </summary>
    public bool ForceRefresh { get; set; }

    /// <summary>Parses command-line arguments into a <see cref="GeneratorOptions"/> instance.</summary>
    public static GeneratorOptions FromArgs(string[] args)
    {
        var opts = new GeneratorOptions();

        for (int i = 0; i < args.Length; i++)
        {
            switch (args[i])
            {
                case "--output" when i + 1 < args.Length:
                    opts.OutputDir = Path.GetFullPath(args[++i]);
                    break;
                case "--cache" when i + 1 < args.Length:
                    opts.CacheDir = Path.GetFullPath(args[++i]);
                    break;
                case "--force":
                    opts.ForceRefresh = true;
                    break;
            }
        }

        return opts;
    }
}