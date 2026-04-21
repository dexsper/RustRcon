using RustRcon.Generator;
using RustRcon.Generator.Analysis;
using RustRcon.Generator.Decompile;
using RustRcon.Generator.Download;
using RustRcon.Generator.Emit;

var opts = GeneratorOptions.FromArgs(args);
var progress = new Progress<string>(msg => Console.WriteLine($"  {msg}"));

Console.WriteLine($"  Output : {opts.OutputDir}");
Console.WriteLine($"  Cache  : {opts.CacheDir}");
Console.WriteLine();

Console.WriteLine("[1/4] Resolving managed DLLs…");
var downloader = new GitHubReleaseDownloader(opts.CacheDir);
var tag = await downloader.EnsureLatestAsync(
    forceRefresh: opts.ForceRefresh,
    progress: progress
);

Console.WriteLine($"      Resolved tag: {tag}");
Console.WriteLine();

Console.WriteLine("[2/4] Decompiling types…");
using var decompiler = new DllDecompiler(downloader.ManagedDir);
var decompiled = decompiler.DecompileAll(progress);
Console.WriteLine($"      Decompiled {decompiled.Count} type(s): {string.Join(", ", decompiled.Keys)}");
Console.WriteLine();

Console.WriteLine("[3/4] Parsing and analysing commands…");

var parser = new ConsoleGenParser();
if (!decompiled.TryGetValue("ConsoleGen", out var consoleGenSource))
{
    Console.Error.WriteLine("ERROR: ConsoleGen type not found. Aborting.");
    return 1;
}

var allCommands = parser.Parse(consoleGenSource);
Console.WriteLine($"      Parsed {allCommands.Count} commands.");

var analyzer = new TypeAnalyzer();
var (dtos, enums) = analyzer.Analyse(allCommands, decompiled);

var playerOnly = allCommands.Count(c => c.RequiresPlayer);
var commands = allCommands.Where(c => !c.RequiresPlayer).ToList();
Console.WriteLine($"      Skipped  {playerOnly} player-context-only command(s).");
Console.WriteLine($"      DTOs     : {string.Join(", ", dtos.Keys.DefaultIfEmpty("(none)"))}");
Console.WriteLine($"      Enums    : {string.Join(", ", enums.Keys.DefaultIfEmpty("(none)"))}");
Console.WriteLine();

Console.WriteLine("[4/4] Emitting generated files…");
if (Directory.Exists(opts.OutputDir))
    Directory.Delete(opts.OutputDir, recursive: true);
Directory.CreateDirectory(opts.OutputDir);

var commandEmitter = new CommandEmitter(opts.OutputDir);
var dtoEmitter = new DtoEmitter(opts.OutputDir);
var enumEmitter = new EnumEmitter(opts.OutputDir);

foreach (var enumDef in enums.Values)
    enumEmitter.Emit(enumDef);

foreach (var dto in dtos.Values)
    dtoEmitter.Emit(dto);

int emittedCount = 0;
foreach (var cmd in commands)
{
    try
    {
        commandEmitter.Emit(cmd);
        emittedCount++;
    }
    catch (Exception ex)
    {
        Console.Error.WriteLine($"  WARNING: Failed to emit {cmd.FullName}: {ex.Message}");
    }
}

Console.WriteLine($"      Emitted {emittedCount} commands, {dtos.Count} DTOs, {enums.Count} enums.");
Console.WriteLine();
Console.WriteLine("Done.");
return 0;