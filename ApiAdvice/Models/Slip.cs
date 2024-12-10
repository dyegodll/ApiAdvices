using System.Text.Json.Serialization;

namespace ApiAdvice.Models;

internal class Slip
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("advice")]
    public string? Advice { get; set; }

    public string Info => $"Advice {Id}: {Advice}";
}
