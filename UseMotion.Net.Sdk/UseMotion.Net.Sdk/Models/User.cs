using Newtonsoft.Json;

namespace UseMotion.Net.Sdk.Models;

public class User
{
    /// <summary>
    /// Identifier of the user
    /// </summary>
    [JsonProperty("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Name of the user
    /// </summary>
    [JsonProperty("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Email of the user
    /// </summary>
    [JsonProperty("email")]
    public string? Email { get; set; }
}