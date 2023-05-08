using Newtonsoft.Json;

namespace UseMotion.Net.Sdk.Models;

public class SubTask
{
    /// <summary>
    /// Name of the subtask
    /// </summary>
    [JsonProperty("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Is the subtask completed
    /// </summary>
    [JsonProperty("completed")]
    public required bool Completed { get; set; }
}