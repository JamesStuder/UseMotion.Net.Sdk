using System;
using Newtonsoft.Json;

namespace UseMotion.Net.Sdk.Models;

public class Comment
{
    /// <summary>
    /// Identifier of the comment
    /// </summary>
    [JsonProperty("id")]
    public required string Id { get; set; }

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

    /// <summary>
    /// The user that created this comment
    /// </summary>
    [JsonProperty("creator")]
    public required User Creator { get; set; }

    /// <summary>
    /// When it was created
    /// </summary>
    [JsonProperty("createdAt")]
    public required DateTime CreatedAt { get; set; }
}