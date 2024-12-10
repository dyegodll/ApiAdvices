using System.Text.Json.Serialization;

namespace ApiAdvice.Models;

internal class ApiResponse
{
    [JsonPropertyName("slip")]
    public Slip? Slip { get; set; }
}
