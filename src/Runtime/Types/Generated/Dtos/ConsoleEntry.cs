using Newtonsoft.Json;

namespace RustRcon.Generated.Dtos;

/// <summary>Generated DTO — do not edit by hand.</summary>
public sealed class ConsoleEntry
{
    [JsonProperty("Message")]
    public string Message { get; set; } = string.Empty;

    [JsonProperty("Stacktrace")]
    public string Stacktrace { get; set; } = string.Empty;

    [JsonProperty("Type")]
    public string Type { get; set; } = string.Empty;

    [JsonProperty("Time")]
    public int Time { get; set; }

}
