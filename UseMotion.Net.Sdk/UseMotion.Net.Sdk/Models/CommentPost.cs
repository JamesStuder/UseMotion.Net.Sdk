using Newtonsoft.Json;

namespace UseMotion.Net.Sdk.Models;

public class CommentPost
{
    /// <summary>
    /// Identifier of linked Task
    /// </summary>
    [JsonProperty("taskId")]
    public required string TaskId { get; set; }

    /// <summary>
    /// Comment body
    /// </summary>
    [JsonProperty("content")]
    public required string Content { get; set; }
}