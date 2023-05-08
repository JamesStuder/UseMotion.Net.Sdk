using Newtonsoft.Json;

namespace UseMotion.Net.Sdk.Models;

public class MoveTask
{
    /// <summary>
    /// Id of the workspace the task should be moved to
    /// </summary>
    [JsonProperty("workspaceId")]
    public required string WorkspaceId { get; set; }

    /// <summary>
    /// The user id the task should be assigned to
    /// </summary>
    [JsonProperty("assigneeId")]
    public string? AssigneeId { get; set; }
}