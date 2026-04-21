RustRcon
===
[![NuGet](https://img.shields.io/nuget/v/RustRcon)](https://www.nuget.org/packages/RustRcon)
[![NuGet](https://img.shields.io/nuget/dt/RustRcon)](https://www.nuget.org/packages/RustRcon)
[![GitHub Actions](https://github.com/dexsper/RustRcon/workflows/Publish/badge.svg)](https://github.com/dexsper/RustRcon/actions)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)

Typed RCON client for [Rust](https://rust.facepunch.com/) game servers. Ships with 1 600+ auto-generated command classes covering every ConVar, action command and admin utility exposed by the game — with correct argument types, get/set semantics for ConVars and structured response objects.

```csharp
using RustRcon;
using RustRcon.Generated.Commands;

var client = new RconClient("localhost", 28016, "password");
await client.ConnectAsync();

// ConVar — get and set
var tfCmd = GlobalMaxplayersCommand.CreateGet();
await client.SendCommandAsync(tfCmd);
Console.WriteLine(tfCmd.Value); // 100

// Typed DTO response
var infoCmd = GlobalServerinfoCommand.Create();
await client.SendCommandAsync(infoCmd);
Console.WriteLine(infoCmd.Result?.Hostname);

// TextTable with --json flag → structured row access
var tcCmd = ServerListtoolcupboardsCommand.Create(json: true);
await client.SendCommandAsync(tcCmd);
foreach (var row in tcCmd.Result?.Rows ?? [])
    Console.WriteLine($"{row["EntityId"]}  {row["Position"]}");
```

## Table of Contents

- [Installation](#installation)
- [Getting started](#getting-started)
- [Commands](#commands)
  - [ConVar commands](#convar-commands)
  - [Action commands](#action-commands)
  - [TextTable commands](#texttable-commands)
- [Unsolicited messages](#unsolicited-messages)
- [CLI tool](#cli-tool)
- [Code generation](#code-generation)

## Installation

### Library

```bash
dotnet add package RustRcon
```

Targets `net10.0` and `netstandard2.1`.

### CLI tool

Download the binary for your platform from the [latest release](https://github.com/dexsper/RustRcon/releases/latest):

| Platform | Archive |
|----------|---------|
| Linux x64 | `rustrcon-cli-vX.X.X-linux-x64.zip` |
| Windows x64 | `rustrcon-cli-vX.X.X-win-x64.zip` |
| macOS x64 | `rustrcon-cli-vX.X.X-osx-x64.zip` |

Extract and run:

```bash
# Linux / macOS
chmod +x rustrcon
./rustrcon --host localhost --port 28016 --password <password>

# Windows
rustrcon.exe --host localhost --port 28016 --password <password>
```

## Getting started

```csharp
using RustRcon;

// The logger parameter is optional — omit to write to console.
var client = new RconClient("localhost", 28016, "password");

await client.ConnectAsync();

// Subscribe to unsolicited server output before connecting if needed.
client.OnConsoleMessage += msg => Console.WriteLine(msg.Message);
client.OnChatMessage    += msg => Console.WriteLine($"<{msg.Username}> {msg.Message}");

await client.DisconnectAsync("bye");
```

## Commands

Every RCON command is a strongly-typed class generated from the game's `ConsoleGen` table.
<br>
All classes live in the `RustRcon.Generated.Commands` namespace.

### ConVar commands

ConVars expose `CreateGet()` and `CreateSet(T value)`.
<br>
After `SendCommandAsync` completes, `Value` holds the parsed result.

```csharp
// Read
var getCmd = GlobalServeripCommand.CreateGet();
await client.SendCommandAsync(getCmd);
Console.WriteLine(getCmd.Value); // e.g. "0.0.0.0"

// Write
var setCmd = GlobalMaxplayersCommand.CreateSet(200);
await client.SendCommandAsync(setCmd);
```

### Action commands

Commands with arguments have a `Create(...)` factory that validates types at compile time.

```csharp
// Ban by Steam ID (SteamId is a validated wrapper around ulong)
var ban = GlobalBanidCommand.Create(
    steamId: new SteamId(76561198000000000),
    reason:  "griefing",
    duration: 86400);

await client.SendCommandAsync(ban);

// Kick all players
var kick = GlobalKickallCommand.Create("server restart in 5 min");
await client.SendCommandAsync(kick);
```

Commands that return a typed response inherit from `BaseCallCommand<T>`.
<br>
`Result` is populated after the command completes.

```csharp
var players = GlobalPlayerlistCommand.Create();
await client.SendCommandAsync(players);

foreach (var p in players.Result ?? [])
    Console.WriteLine($"{p.DisplayName}  {p.SteamID}  {p.Ping}ms");
```

### TextTable commands

Commands that use `TextTable` internally support an optional `--json` flag.
<br>
`Result.Rows` is always populated regardless of which format the server returns.

```csharp
// Without --json: server replies with padded text, parsed into rows automatically.
var tcText = ServerListtoolcupboardsCommand.Create();
await client.SendCommandAsync(tcText);

// With --json: server replies with a JSON array.
var tcJson = ServerListtoolcupboardsCommand.Create(json: true);
await client.SendCommandAsync(tcJson);

foreach (var row in tcJson.Result?.Rows ?? [])
    Console.WriteLine($"{row["EntityId"]}  {row["Position"]}  authed={row["Authed"]}");

// Raw text is always available regardless of format.
Console.WriteLine(tcJson.Result?.Raw);
```

## Unsolicited messages

The server pushes chat and console messages without a request. Subscribe before connecting.

```csharp
client.OnConsoleMessage += msg =>
{
    Console.WriteLine($"[{msg.Type}] {msg.Message}");
};

client.OnChatMessage += msg =>
{
    Console.WriteLine($"[Chat] <{msg.Username}> {msg.Message}");
};
```

## CLI tool

The `rustrcon` CLI connects to any Rust server and provides an interactive REPL with autocomplete, history and structured response rendering.

```
rustrcon --host localhost --port 28016 --password <password>

> _
```

| Key / command          | Action                                      |
|------------------------|---------------------------------------------|
| `TAB`                  | Cycle through completions (full name or short name) |
| `↑` / `↓`              | Navigate command history                    |
| `find <query>`         | Search commands by name or description      |
| `clear`                | Clear the terminal                          |
| `exit`                 | Disconnect and quit                         |

Short names are resolved automatically when unambiguous:

```
> serverinfo             → resolves to global.serverinfo
> ban <steamId>          → ambiguous: global.ban / global.banid / …
```

Responses are rendered as structured tables where possible.

## Code generation

The generated files under `src/Runtime/Types/Generated/` are committed to this repository.
<br>
To regenerate against a new game version:

```bash
dotnet run --project src/Generator -- \
  --output src/Runtime/Types/Generated

# Force re-download even if the cached Oxide.Rust tag matches:
dotnet run --project src/Generator -- \
  --output src/Runtime/Types/Generated \
  --force
```

The generator:

1. Downloads the latest `Oxide.Rust.zip` from [OxideMod/Oxide.Rust](https://github.com/OxideMod/Oxide.Rust/releases/latest) and caches it under `%LOCALAPPDATA%/RustRconGenerator`.
2. Decompiles `Assembly-CSharp.dll` with [ICSharpCode.Decompiler](https://github.com/icsharpcode/ILSpy).
3. Parses `ConsoleGen` to extract every command definition, infers C# types for each argument and return value.
4. Emits command classes, DTO records and enums.

## License

This library is under the MIT License.
