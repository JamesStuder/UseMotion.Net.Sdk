using Newtonsoft.Json;

namespace UseMotion.Net.Sdk.Models;

public class Label
{
    /// <summary>
    /// Label Name
    /// </summary>
    [JsonProperty("name")]
    public required string Name { get; set; }
}